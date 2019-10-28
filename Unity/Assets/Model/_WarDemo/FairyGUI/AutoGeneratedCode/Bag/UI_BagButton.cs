/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace ETModel.Bag
{
	public partial class UI_BagButton : GButton
	{
		public Controller m_button;
		public GImage m_n1;

		public const string URL = "ui://a3ymflkcg3vcq";

		public static UI_BagButton CreateInstance()
		{
			return (UI_BagButton)UIPackage.CreateObject("Bag","BagButton");
		}

		public UI_BagButton()
		{
		}

		public override void ConstructFromXML(XML xml)
		{
			base.ConstructFromXML(xml);

			m_button = this.GetControllerAt(0);
			m_n1 = (GImage)this.GetChildAt(0);
		}
	}
}