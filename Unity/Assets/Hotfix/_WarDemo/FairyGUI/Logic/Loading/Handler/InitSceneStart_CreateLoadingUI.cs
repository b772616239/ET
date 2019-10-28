using ETHotfix.Common;
using ETModel;
using UnityEngine;

namespace ETHotfix
{
    [Event(EventIdType.InitSceneStart)]
	public class InitSceneStart_CreateLoadingUI : AEvent
	{
        public override void Run()
        {
            var fui = FUILoading.CreateInstance();

            //默认将会以Id为Name，也可以自定义Name，方便查询和管理
            fui.Name = FUILoading.UIResName;

            fui.MakeFullScreen();
        
            var fuiCom= Game.Scene.AddComponent<FUIComponent>();
            if (fuiCom!=null)
            {
                fuiCom.Add(fui, true);

            }
            else
            {
                Debug.LogError(string.Format("<color=#ff0000ff><---{0}-{1}----></color>", "test", "test1"));

            }
        }
    }
}