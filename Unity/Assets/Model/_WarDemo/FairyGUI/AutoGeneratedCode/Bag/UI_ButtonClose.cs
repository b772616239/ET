/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace ETModel.Bag
{
	public partial class UI_ButtonClose : GButton
	{
		public Controller m_button;
		public GImage m_n1;
		public GImage m_n2;

		public const string URL = "ui://a3ymflkcg3vcn";

		public static UI_ButtonClose CreateInstance()
		{
			return (UI_ButtonClose)UIPackage.CreateObject("Bag","ButtonClose");
		}

		public UI_ButtonClose()
		{
		}

		public override void ConstructFromXML(XML xml)
		{
			base.ConstructFromXML(xml);

			m_button = this.GetControllerAt(0);
			m_n1 = (GImage)this.GetChildAt(0);
			m_n2 = (GImage)this.GetChildAt(1);
		}
	}
}