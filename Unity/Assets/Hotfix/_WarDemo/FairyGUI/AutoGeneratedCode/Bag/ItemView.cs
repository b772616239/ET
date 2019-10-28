/** This is an automatically generated class by FairyGUI plugin FGUI2ET. Please do not modify it. **/

using System.Threading.Tasks;
using FairyGUI;
using ETModel;
using ETHotfix;

namespace ETHotfix.Bag
{
    [ObjectSystem]
    public class ItemViewAwakeSystem : AwakeSystem<ItemView, GObject>
    {
        public override void Awake(ItemView self, GObject go)
        {
            self.Awake(go);
        }
    }
	
	public sealed class ItemView : FUI
	{	
		public const string UIPackageName = "Bag";
		public const string UIResName = "ItemView";
		
		/// <summary>
        /// ItemView的组件类型(GComponent、GButton、GProcessBar等)，它们都是GObject的子类。
        /// </summary>
		public GButton self;
		
		public Controller button;
		public GImage BG;
		public GLoader icon;
		public GTextField title;

		private static GObject CreateGObject()
        {
            return UIPackage.CreateObject(UIPackageName, UIResName);
        }
		
		private static void CreateGObjectAsync(UIPackage.CreateObjectCallback result)
        {
            UIPackage.CreateObjectAsync(UIPackageName, UIResName, result);
        }

        public static ItemView CreateInstance()
		{			
			return EntityFactory.Create<ItemView, GObject >(Game.Scene,CreateGObject());
		}

        public static Task<ItemView> CreateInstanceAsync()
        {
            TaskCompletionSource<ItemView> tcs = new TaskCompletionSource<ItemView>();

            CreateGObjectAsync((go) =>
            {
                tcs.SetResult(EntityFactory.Create<ItemView, GObject >(Game.Scene,go));
            });

            return tcs.Task;
        }

        public static ItemView Create(GObject go)
		{
			return EntityFactory.Create<ItemView, GObject >(Game.Scene,go);
		}
		
        /// <summary>
        /// 通过此方法获取的FUI，在Dispose时不会释放GObject，需要自行管理（一般在配合FGUI的Pool机制时使用）。
        /// </summary>
        public static ItemView GetFormPool(GObject go)
        {
            var fui = go.Get<ItemView>();

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
				BG = (GImage)com.GetChild("BG");
				icon = (GLoader)com.GetChild("icon");
				title = (GTextField)com.GetChild("title");
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
			BG = null;
			icon = null;
			title = null;
		}
	}
}