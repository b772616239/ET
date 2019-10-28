/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace ETModel.Bag
{
	public partial class UI_Item : GButton
	{
		public Controller m_buttonCtrl;
		public GImage m_BG;
		public GTextField m_title;
		public GLoader m_icon;
		public GImage m_button;
		public GImage m_n2;

		public const string URL = "ui://a3ymflkcg3vco";

		public static UI_Item CreateInstance()
		{
			return (UI_Item)UIPackage.CreateObject("Bag","Item");
		}

		public UI_Item()
		{
		}

		public override void ConstructFromXML(XML xml)
		{
			base.ConstructFromXML(xml);

			m_buttonCtrl = this.GetControllerAt(0);
			m_BG = (GImage)this.GetChildAt(0);
			m_title = (GTextField)this.GetChildAt(1);
			m_icon = (GLoader)this.GetChildAt(2);
			m_button = (GImage)this.GetChildAt(3);
			m_n2 = (GImage)this.GetChildAt(4);
		}
	}
}