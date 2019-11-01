
using ETModel;
using UnityEngine;

namespace ETHotfix
{
    [Event(EventIdType.InitSceneStart)]
    public class InitSceneStart_CreateLoadingUI : AEvent
    {
        public override void Run()
        {
            ETModel.Game.Scene.AddComponent<FUIPackageComponent>().AddPackage(FUIPackage.LoginPack);

            //默认将会以Id为Name，也可以自定义Name，方便查询和管理
            var loginView = LoginFactory.Create();

            var fuiCom = Game.Scene.AddComponent<FUIComponent>();
            if (fuiCom != null)
            {
                fuiCom.Add(loginView, true);

            }
            else
            {
                Debug.LogError(string.Format("<color=#ff0000ff><---{0}-{1}----></color>", "test", "test1"));

            }
            // ETModel.Game.Scene.GetComponent<FUIPackageComponent>().RemovePackage(FUIPackage.LoginPack);
            Game.EventSystem.Run(EventIdType.Dialog, "欢迎来到帝国战争");
        
        }
    }
}