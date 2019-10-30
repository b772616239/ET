using ETModel;
using System.Threading.Tasks;

namespace ETHotfix
{
	public class FUIInitComponent : Entity
    {
        public async Task Init()
        {
            // await ETModel.Game.Scene.AddComponent<FUIPackageComponent>().AddPackageAsync(FUIPackage.Common);
            //await ETModel.Game.Scene.AddComponent<FUIPackageComponent>().AddPackageAsync(LoginView.LoginComponent.UIPackageName);
        }

        public override void Dispose()
		{
			if (IsDisposed)
			{
				return;
			}

			base.Dispose();

            // ETModel.Game.Scene.GetComponent<FUIPackageComponent>().RemovePackage(FUIPackage.Common);
            // ETModel.Game.Scene.GetComponent<FUIPackageComponent>().RemovePackage(LoginView.LoginComponent.UIPackageName);

        }
    }
}