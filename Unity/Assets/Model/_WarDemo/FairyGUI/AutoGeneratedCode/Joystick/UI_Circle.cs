/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace ETModel.Joystick
{
	public partial class UI_Circle : GButton
	{
		public Controller m_button;
		public GImage m_thumb;

		public const string URL = "ui://4yh2g7utja0i3";

		public static UI_Circle CreateInstance()
		{
			return (UI_Circle)UIPackage.CreateObject("Joystick","Circle");
		}

		public UI_Circle()
		{
		}

		public override void ConstructFromXML(XML xml)
		{
			base.ConstructFromXML(xml);

			m_button = this.GetControllerAt(0);
			m_thumb = (GImage)this.GetChildAt(0);
		}
	}
}