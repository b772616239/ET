using ETModel;
using ETHotfix.LoginPack;
using UnityEngine;
namespace ETHotfix{
	[ObjectSystem]
	public class LoginComponentStartSystem : StartSystem<LoginComponent>
	{
		public override void Start(LoginComponent self)
		{
            
		}
	}
	[ObjectSystem]
	public class LoginComponentUpdateSystem : UpdateSystem<LoginComponent>
	{
		public override void Update(LoginComponent self)
		{
            
		}
	}
	[ObjectSystem]
	public class LoginComponentDestroySystem : DestroySystem<LoginComponent>
	{
		public override void Destroy(LoginComponent self)
		{
            
		}
	}
}