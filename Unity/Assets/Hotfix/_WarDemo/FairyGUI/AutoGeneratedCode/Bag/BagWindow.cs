/** This is an automatically generated class by FairyGUI plugin FGUI2ET. Please do not modify it. **/

using System.Threading.Tasks;
using FairyGUI;
using ETModel;
using ETHotfix;

namespace ETHotfix.Bag
{
    [ObjectSystem]
    public class BagWindowAwakeSystem : AwakeSystem<BagWindow, GObject>
    {
        public override void Awake(BagWindow self, GObject go)
        {
            self.Awake(go);
        }
    }
	
	public sealed class BagWindow : FUI
	{	
		public const string UIPackageName = "Bag";
		public const string UIResName = "BagWindow";
		
		/// <summary>
        /// BagWindow的组件类型(GComponent、GButton、GProcessBar等)，它们都是GObject的子类。
        /// </summary>
		public GComponent self;
		
		public WindowFrame frame;
		public GList ItemList;

		private static GObject CreateGObject()
        {
            return UIPackage.CreateObject(UIPackageName, UIResName);
        }
		
		private static void CreateGObjectAsync(UIPackage.CreateObjectCallback result)
        {
            UIPackage.CreateObjectAsync(UIPackageName, UIResName, result);
        }

        public static BagWindow CreateInstance()
		{			
			return EntityFactory.Create<BagWindow, GObject >(Game.Scene,CreateGObject());
		}

        public static Task<BagWindow> CreateInstanceAsync()
        {
            TaskCompletionSource<BagWindow> tcs = new TaskCompletionSource<BagWindow>();

            CreateGObjectAsync((go) =>
            {
                tcs.SetResult(EntityFactory.Create<BagWindow, GObject >(Game.Scene,go));
            });

            return tcs.Task;
        }

        public static BagWindow Create(GObject go)
		{
			return EntityFactory.Create<BagWindow, GObject >(Game.Scene,go);
		}
		
        /// <summary>
        /// 通过此方法获取的FUI，在Dispose时不会释放GObject，需要自行管理（一般在配合FGUI的Pool机制时使用）。
        /// </summary>
        public static BagWindow GetFormPool(GObject go)
        {
            var fui = go.Get<BagWindow>();

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
			
			self = (GComponent)go;
			
			self.Add(this);
			
			var com = go.asCom;
				
			if(com != null)
			{	
				frame = WindowFrame.Create(com.GetChild("frame"));
				ItemList = (GList)com.GetChild("ItemList");
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
			frame.Dispose();
			frame = null;
			ItemList = null;
		}
	}
}