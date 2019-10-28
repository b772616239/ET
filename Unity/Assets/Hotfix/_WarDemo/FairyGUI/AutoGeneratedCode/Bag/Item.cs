/** This is an automatically generated class by FairyGUI plugin FGUI2ET. Please do not modify it. **/

using System.Threading.Tasks;
using FairyGUI;
using ETModel;
using ETHotfix;

namespace ETHotfix.Bag
{
    [ObjectSystem]
    public class ItemAwakeSystem : AwakeSystem<Item, GObject>
    {
        public override void Awake(Item self, GObject go)
        {
            self.Awake(go);
        }
    }
	
	public sealed class Item : FUI
	{	
		public const string UIPackageName = "Bag";
		public const string UIResName = "Item";
		
		/// <summary>
        /// Item的组件类型(GComponent、GButton、GProcessBar等)，它们都是GObject的子类。
        /// </summary>
		public GButton self;
		
		public Controller buttonCtrl;
		public GImage BG;
		public GTextField title;
		public GLoader icon;
		public GImage button;
		public GImage n2;

		private static GObject CreateGObject()
        {
            return UIPackage.CreateObject(UIPackageName, UIResName);
        }
		
		private static void CreateGObjectAsync(UIPackage.CreateObjectCallback result)
        {
            UIPackage.CreateObjectAsync(UIPackageName, UIResName, result);
        }

        public static Item CreateInstance()
		{			
			return EntityFactory.Create<Item, GObject >(Game.Scene,CreateGObject());
		}

        public static Task<Item> CreateInstanceAsync()
        {
            TaskCompletionSource<Item> tcs = new TaskCompletionSource<Item>();

            CreateGObjectAsync((go) =>
            {
                tcs.SetResult(EntityFactory.Create<Item, GObject >(Game.Scene,go));
            });

            return tcs.Task;
        }

        public static Item Create(GObject go)
		{
			return EntityFactory.Create<Item, GObject >(Game.Scene,go);
		}
		
        /// <summary>
        /// 通过此方法获取的FUI，在Dispose时不会释放GObject，需要自行管理（一般在配合FGUI的Pool机制时使用）。
        /// </summary>
        public static Item GetFormPool(GObject go)
        {
            var fui = go.Get<Item>();

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
				buttonCtrl = com.GetController("buttonCtrl");
				BG = (GImage)com.GetChild("BG");
				title = (GTextField)com.GetChild("title");
				icon = (GLoader)com.GetChild("icon");
				button = (GImage)com.GetChild("button");
				n2 = (GImage)com.GetChild("n2");
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
			buttonCtrl = null;
			BG = null;
			title = null;
			icon = null;
			button = null;
			n2 = null;
		}
	}
}