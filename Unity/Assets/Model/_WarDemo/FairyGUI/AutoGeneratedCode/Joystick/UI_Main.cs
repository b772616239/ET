/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace ETModel.Joystick
{
	public partial class UI_Main : GComponent
	{
		public GImage m_JoystickCenter;
		public UI_Circle m_Joystick;
		public GGraph m_JoystickTouchArea;
		public GTextField m_n3;
		public GTextField m_n4;

		public const string URL = "ui://4yh2g7utja0i0";

		public static UI_Main CreateInstance()
		{
			return (UI_Main)UIPackage.CreateObject("Joystick","Main");
		}

		public UI_Main()
		{
		}

		public override void ConstructFromXML(XML xml)
		{
			base.ConstructFromXML(xml);

			m_JoystickCenter = (GImage)this.GetChildAt(0);
			m_Joystick = (UI_Circle)this.GetChildAt(1);
			m_JoystickTouchArea = (GGraph)this.GetChildAt(2);
			m_n3 = (GTextField)this.GetChildAt(3);
			m_n4 = (GTextField)this.GetChildAt(4);
		}
	}
}