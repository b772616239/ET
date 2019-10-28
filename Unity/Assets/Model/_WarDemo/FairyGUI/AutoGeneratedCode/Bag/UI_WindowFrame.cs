/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace ETModel.Bag
{
	public partial class UI_WindowFrame : GComponent
	{
		public GImage m_BG;
		public UI_ButtonClose m_closeButton;
		public GGraph m_dragArea;

		public const string URL = "ui://a3ymflkcg3vc3";

		public static UI_WindowFrame CreateInstance()
		{
			return (UI_WindowFrame)UIPackage.CreateObject("Bag","WindowFrame");
		}

		public UI_WindowFrame()
		{
		}

		public override void ConstructFromXML(XML xml)
		{
			base.ConstructFromXML(xml);

			m_BG = (GImage)this.GetChildAt(0);
			m_closeButton = (UI_ButtonClose)this.GetChildAt(1);
			m_dragArea = (GGraph)this.GetChildAt(2);
		}
	}
}