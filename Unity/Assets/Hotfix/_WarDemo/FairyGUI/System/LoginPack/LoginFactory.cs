using ETHotfix.LoginPack;
using ETModel;
using UnityEngine;

namespace ETHotfix
{
	public static class LoginFactory
	{
		public static FUI Create()
		{

		       var LoginView =LoginComponent.CreateInstance();
		       LoginView.MakeFullScreen();
			   return LoginView;
		}
	}
}
