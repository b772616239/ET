/** This is an automatically generated class by FairyGUI plugin FGUI2ET. Please do not modify it. **/

using System.Threading.Tasks;
using FairyGUI;
using ETModel;
using ETHotfix;

namespace ETHotfix.Bag
{
    [ObjectSystem]
    public class BagButtonAwakeSystem : AwakeSystem<BagButton, GObject>
    {
        public override void Awake(BagButton self, GObject go)
        {
            self.Awake(go);
        }
    }
	
	public sealed class BagButton : FUI
	{	
		public const string UIPackageName = "Bag";
		public const string UIResName = "BagButton";
		
		/// <summary>
        /// BagButton的组件类型(GComponent、GButton、GProcessBar等)，它们都是GObject的子类。
        /// </summary>
		public GButton self;
		
		public Controller button;
		public GImage n1;

		private static GObject CreateGObject()
        {
            return UIPackage.CreateObject(UIPackageName, UIResName);
        }
		
		private static void CreateGObjectAsync(UIPackage.CreateObjectCallback result)
        {
            UIPackage.CreateObjectAsync(UIPackageName, UIResName, result);
        }

        public static BagButton CreateInstance()
		{			
			return EntityFactory.Create<BagButton, GObject >(Game.Scene,CreateGObject());
		}

        public static Task<BagButton> CreateInstanceAsync()
        {
            TaskCompletionSource<BagButton> tcs = new TaskCompletionSource<BagButton>();

            CreateGObjectAsync((go) =>
            {
                tcs.SetResult(EntityFactory.Create<BagButton, GObject >(Game.Scene,go));
            });

            return tcs.Task;
        }

        public static BagButton Create(GObject go)
		{
			return EntityFactory.Create<BagButton, GObject >(Game.Scene,go);
		}
		
        /// <summary>
        /// 通过此方法获取的FUI，在Dispose时不会释放GObject，需要自行管理（一般在配合FGUI的Pool机制时使用）。
        /// </summary>
        public static BagButton GetFormPool(GObject go)
        {
            var fui = go.Get<BagButton>();

            if(fui == null)
            {
                fui = Create(go);
            }

            fui.isFromFGUIPool = true;

            return fui;
        }
						
		public void Awake(GObject go)
		{
			if(go == null)
			{
				return;
			}
			
			GObject = go;	
			
			if (string.IsNullOrWhiteSpace(Name))
            {
				Name = Id.ToString();
            }
			
			self = (GButton)go;
			
			self.Add(this);
			
			var com = go.asCom;
				
			if(com != null)
			{	
				button = com.GetController("button");
				n1 = (GImage)com.GetChild("n1");
			}
		}
		
		public override void Dispose()
		{
			if(IsDisposed)
			{
				return;
			}
			
			base.Dispose();
			
			self.Remove();
			self = null;
			button = null;
			n1 = null;
		}
	}
}