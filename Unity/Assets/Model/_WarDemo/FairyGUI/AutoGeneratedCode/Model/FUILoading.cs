/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;
using UnityEngine;

namespace ETModel.Model
{
	public partial class FUILoading : GComponent
	{
		public GImage bg;
		public FUILoadingProgressBar loadingBar;
		public GTextField loadingText;

		public const string URL = "ui://2w4fpdl4ofor0";

		public static FUILoading CreateInstance()
		{
			return (FUILoading)UIPackage.CreateObject("Model","Loading");
		}

		public FUILoading()
		{
		}

		public override void ConstructFromXML(XML xml)
		{
			base.ConstructFromXML(xml);

			bg = (GImage)this.GetChild("bg");
			loadingBar = (FUILoadingProgressBar)this.GetChild("loadingBar");
			loadingText = (GTextField)this.GetChild("loadingText");

            Debug.Log(string.Format("<color=#ffffffff><---{0}-{1}----></color>", loadingBar.value, "test1"));
            
        }
        public void SetValue(double value)
        {
            loadingBar.value = value;

        }
    }
}