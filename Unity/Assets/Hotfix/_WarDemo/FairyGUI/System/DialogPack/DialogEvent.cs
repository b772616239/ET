
using ETModel;
using UnityEngine;

namespace ETHotfix
{
    [Event(EventIdType.Dialog)]
    public class DialogEvent : AEvent<string>
    {
        public override void Run(string a)
        {
            ETModel.Game.Scene.GetComponent<FUIPackageComponent>().AddPackage(FUIPackage.DialogPack);

            //默认将会以Id为Name，也可以自定义Name，方便查询和管理
            var view = DialogFactory.Create();
            view.ShowIn.text = a;
            var fuiCom = Game.Scene.GetComponent<FUIComponent>();
            if (fuiCom != null)
            {
                fuiCom.Add(view, true);

            }
            else
            {
                Debug.LogError(string.Format("<color=#ff0000ff><---{0}-{1}----></color>", "test", "test1"));

            }

        }
    }
}
