﻿using ETModel.Model;
using FairyGUI;

namespace ETModel
{
    [ObjectSystem]
	public class FUIInitComponentAwakeSystem : AwakeSystem<FUIInitComponent>
	{
		public override void Awake(FUIInitComponent self)
		{
            self.Awake();
		}
	}

	public class FUIInitComponent : Entity
    {
        public const string DefaultFont = "FZXuanZhenZhuanBianS-R-GB";
        public static string ModelPackageName = "FUI/Model";
        private UIPackage modelPackage;

        public void Awake()
        {
            UIConfig.defaultFont = DefaultFont;
            modelPackage = UIPackage.AddPackage(ModelPackageName);
            ModelBinder.BindAll();
        }

        public override void Dispose()
		{
			if (IsDisposed)
			{
				return;
			}

			base.Dispose();

            if(modelPackage != null)
            {
                var p = UIPackage.GetByName(modelPackage.name);

                if(p != null)
                {
                    UIPackage.RemovePackage(modelPackage.name);
                }

                modelPackage = null;
            }
        }
    }
}