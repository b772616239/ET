/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace ETModel.Bag
{
	public partial class UI_BagWindow : GComponent
	{
		public UI_WindowFrame m_frame;
		public GList m_ItemList;

		public const string URL = "ui://a3ymflkcg3vc2";

		public static UI_BagWindow CreateInstance()
		{
			return (UI_BagWindow)UIPackage.CreateObject("Bag","BagWindow");
		}

		public UI_BagWindow()
		{
		}

		public override void ConstructFromXML(XML xml)
		{
			base.ConstructFromXML(xml);

			m_frame = (UI_WindowFrame)this.GetChildAt(0);
			m_ItemList = (GList)this.GetChildAt(1);
		}
	}
}