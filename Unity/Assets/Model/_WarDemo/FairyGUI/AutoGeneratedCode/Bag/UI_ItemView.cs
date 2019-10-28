/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace ETModel.Bag
{
	public partial class UI_ItemView : GButton
	{
		public Controller m_button;
		public GImage m_BG;
		public GLoader m_icon;
		public GTextField m_title;

		public const string URL = "ui://a3ymflkcg3vcp";

		public static UI_ItemView CreateInstance()
		{
			return (UI_ItemView)UIPackage.CreateObject("Bag","ItemView");
		}

		public UI_ItemView()
		{
		}

		public override void ConstructFromXML(XML xml)
		{
			base.ConstructFromXML(xml);

			m_button = this.GetControllerAt(0);
			m_BG = (GImage)this.GetChildAt(0);
			m_icon = (GLoader)this.GetChildAt(1);
			m_title = (GTextField)this.GetChildAt(2);
		}
	}
}