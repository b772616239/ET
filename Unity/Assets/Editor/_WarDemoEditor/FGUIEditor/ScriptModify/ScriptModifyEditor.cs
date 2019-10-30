﻿using ETPlus;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEditor;
using UnityEngine;
using static ETPlus.AutoGenerateCodeEditor;

public class ScriptModifyEditor : AssetPostprocessor
{
    //模型导入之前调用
    public void OnPreprocessModel()
    {
        Debug.Log("OnPreprocessModel=" + this.assetPath);
    }

    //模型导入之前调用
    public void OnPostprocessModel(GameObject go)
    {
        Debug.Log("OnPostprocessModel=" + go.name);
    }

    //纹理导入之前调用，针对入到的纹理进行设置
    public void OnPreprocessTexture()
    {
        Debug.Log("OnPreProcessTexture=" + this.assetPath);
        TextureImporter impor = this.assetImporter as TextureImporter;
        impor.textureFormat = TextureImporterFormat.ARGB32;
        impor.maxTextureSize = 512;
        impor.textureType = TextureImporterType.Default;
        impor.mipmapEnabled = false;

    }

    public void OnPostprocessTexture(Texture2D tex)
    {
        Debug.Log("OnPostProcessTexture=" + this.assetPath);
    }


    public void OnPostprocessAudio(AudioClip clip)
    {

    }

    //public void OnPreprocessAudio()
    //{
    //    AudioImporter audio = this.assetImporter as AudioImporter;
    //    audio.format = AudioImporterFormat.Compressed;
    //}

    //所有的资源的导入，删除，移动，都会调用此方法，注意，这个方法是static的
    public static void OnPostprocessAllAssets(string[] importedAsset, string[] deletedAssets, string[] movedAssets, string[] movedFromAssetPaths)
    {
        Debug.Log("OnPostprocessAllAssets");
        foreach (string assetPath in importedAsset)
        {
            var extension= Path.GetExtension(assetPath);

           // Debug.Log(string.Format("<color=#ffffffff><---{0}-{1}----></color>", extension, "test1"));

            switch (extension)
            {
                case ".cs":
                     var LastDir=Path.GetDirectoryName(assetPath);
                    var ParentFolderName = Path.GetFileNameWithoutExtension(LastDir);

                    Debug.Log(string.Format("<color=#ffffffff><--LastDir-{0}-{1}----></color>", LastDir, "test1"));

                    var root = Path.GetDirectoryName(LastDir);
                 
                    var  parentParentName= Path.GetFileName(root);

                    var fairyGUIFolder = Path.GetDirectoryName(root);


                    if (parentParentName== "AutoGeneratedCode")
                    {
                        var fileName = Path.GetFileNameWithoutExtension(assetPath);

                        var scriptContent = File.ReadAllText(assetPath);

                        var errorInfo = "ComponentFactory";
                        var fixedInfo = "EntityFactory";

                        var errorInfo2 = "GObject>(";
                        var fixedInfo2 = "GObject >(Game.Scene,";
                        
                        scriptContent= scriptContent.Replace(errorInfo, fixedInfo);

                        scriptContent = scriptContent.Replace(errorInfo2, fixedInfo2);
                        
                    
                        File.WriteAllText(assetPath, scriptContent);

                        if (fileName.EndsWith("Component"))
                        {
                            var dirName= fairyGUIFolder + $@"\System\{ParentFolderName}\";
                            var sysFilePath =(dirName+$"{fileName}System.cs");
                            if (!File.Exists(sysFilePath))
                            {
                                 Directory.CreateDirectory(dirName);
                                AutoGenerateCodeEditor.CreateScript(ScriptType.Component, $"{fileName}", sysFilePath, false);

                                Debug.Log(string.Format("<color=#ffffffff><---{0}-{1}----></color>", sysFilePath, "test1"));

                            }

                            var realName = fileName.Replace("Component", "");

                            var eventdirName = fairyGUIFolder + $@"\System\{ParentFolderName}\";
                            var eventFilePath = (dirName + $"{realName}Event.cs");
                            if (!File.Exists(eventFilePath))
                            {
                                Directory.CreateDirectory(eventdirName);

                                AutoGenerateCodeEditor.CreateScript(ScriptType.Event, $"{realName}Event", eventFilePath, false);
                            }

                            var factDirName = fairyGUIFolder + $@"\System\{ParentFolderName}\";
                            var factFilePath = (dirName + $"{realName}Factory.cs");
                            if (!File.Exists(factFilePath))
                            {
                                Directory.CreateDirectory(factDirName);

                                AutoGenerateCodeEditor.CreateScript(ScriptType.Factory, $"{realName}Factory", factFilePath, false);
                            }

                            Debug.Log(string.Format("<color=#ffffffff><---{0}-{1}----></color>", sysFilePath, fairyGUIFolder));
                            Debug.Log(string.Format("<color=#ffffffff><---{0}-{1}----></color>", eventFilePath, fairyGUIFolder));


                        }

                        // File.WriteAllText()
                    }
                    //Debug.Log(string.Format("<color=#ffffffff><---{0}-{1}----></color>", root, "test1"));


                    
                    break;
                default:
                    break;
            }
           // Debug.Log("importedAsset = " + str);
        }
        foreach (string str in deletedAssets)
        {
            Debug.Log("deletedAssets = " + str);
        }
        foreach (string str in movedAssets)
        {
            Debug.Log("movedAssets = " + str);
        }
        foreach (string str in movedFromAssetPaths)
        {
            Debug.Log("movedFromAssetPaths = " + str);
        }
        AssetDatabase.Refresh();
    }
}
