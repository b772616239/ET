using ETModel;
using ETHotfix.DialogPack;
using UnityEngine;
namespace ETHotfix{
	[ObjectSystem]
	public class DialogComponentStartSystem : StartSystem<DialogComponent>
	{
		public override void Start(DialogComponent self)
		{
            
		}
	}
	[ObjectSystem]
	public class DialogComponentUpdateSystem : UpdateSystem<DialogComponent>
	{
		public override void Update(DialogComponent self)
		{
            
		}
	}
	[ObjectSystem]
	public class DialogComponentDestroySystem : DestroySystem<DialogComponent>
	{
		public override void Destroy(DialogComponent self)
		{
            
		}
	}
}