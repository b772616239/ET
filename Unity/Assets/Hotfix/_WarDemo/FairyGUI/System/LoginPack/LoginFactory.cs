using ETHotfix.LoginPack;
using ETModel;
using UnityEngine;

namespace ETHotfix
{
	public static class LoginFactory
	{
		public static FUI Create()
		{

            var loginView = LoginComponent.CreateInstance();

            loginView.MakeFullScreen();
            return loginView;
		}
	}
}
