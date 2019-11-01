using ETHotfix.DialogPack;
using ETModel;
using UnityEngine;

namespace ETHotfix
{
	public static class DialogFactory
	{
		public static DialogComponent Create()
		{
			var DialogView =DialogComponent.CreateInstance();

			DialogView.MakeFullScreen();

			return DialogView;
		}
	}
}
