using ETHotfix.DialogPack;
using ETModel;
using UnityEngine;

namespace ETHotfix
{
	public static class DialogFactory
	{
		public static FUI Create()
		{
            var view = DialogComponent.CreateInstance();

            view.MakeFullScreen();


            return view;
		}
	}
}
