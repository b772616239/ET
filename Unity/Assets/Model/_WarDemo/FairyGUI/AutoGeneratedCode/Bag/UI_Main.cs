/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace ETModel.Bag
{
	public partial class UI_Main : GComponent
	{
		public UI_BagButton m_BagButton;
		public GMovieClip m_n1;
		public UI_ItemView m_playerView;

		public const string URL = "ui://a3ymflkcg3vc0";

		public static UI_Main CreateInstance()
		{
			return (UI_Main)UIPackage.CreateObject("Bag","Main");
		}

		public UI_Main()
		{
		}

		public override void ConstructFromXML(XML xml)
		{
			base.ConstructFromXML(xml);

			m_BagButton = (UI_BagButton)this.GetChildAt(0);
			m_n1 = (GMovieClip)this.GetChildAt(1);
			m_playerView = (UI_ItemView)this.GetChildAt(2);
		}
	}
}