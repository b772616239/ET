﻿using FairyGUI;

namespace ETModel
{
	[ObjectSystem]
	public class FUIComponentAwakeSystem : AwakeSystem<FUIComponent>
	{
		public override void Awake(FUIComponent self)
		{
			GRoot.inst.SetContentScaleFactor(1280, 720, UIContentScaler.ScreenMatchMode.MatchWidthOrHeight);
			self.Root = EntityFactory.Create<FUI, GObject>(self,GRoot.inst);
		}
	}

	/// <summary>
	/// 管理所有顶层UI, 顶层UI都是GRoot的孩子
	/// </summary>
	public class FUIComponent: Entity
	{
		public FUI Root;
		
		public override void Dispose()
		{
			if (IsDisposed)
			{
				return;
			}

			base.Dispose();
			
            Root.Dispose();
            Root = null;
        }

		public void Add(FUI ui)
		{
			Root.Add(ui);
		}
		
		public void Remove(string name)
		{
			Root.Remove(name);
		}
		
		public FUI Get(string name)
		{
			return Root.Get(name);
        }
	}
}