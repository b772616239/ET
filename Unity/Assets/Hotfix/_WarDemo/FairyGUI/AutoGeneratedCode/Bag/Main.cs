/** This is an automatically generated class by FairyGUI plugin FGUI2ET. Please do not modify it. **/

using System.Threading.Tasks;
using FairyGUI;
using ETModel;
using ETHotfix;

namespace ETHotfix.Bag
{
    [ObjectSystem]
    public class MainAwakeSystem : AwakeSystem<Main, GObject>
    {
        public override void Awake(Main self, GObject go)
        {
            self.Awake(go);
        }
    }
	
	public sealed class Main : FUI
	{	
		public const string UIPackageName = "Bag";
		public const string UIResName = "Main";
		
		/// <summary>
        /// Main的组件类型(GComponent、GButton、GProcessBar等)，它们都是GObject的子类。
        /// </summary>
		public GComponent self;
		
		public BagButton BagButton;
		public GMovieClip n1;
		public ItemView playerView;

		private static GObject CreateGObject()
        {
            return UIPackage.CreateObject(UIPackageName, UIResName);
        }
		
		private static void CreateGObjectAsync(UIPackage.CreateObjectCallback result)
        {
            UIPackage.CreateObjectAsync(UIPackageName, UIResName, result);
        }

        public static Main CreateInstance()
		{			
			return EntityFactory.Create<Main, GObject >(Game.Scene,CreateGObject());
		}

        public static Task<Main> CreateInstanceAsync()
        {
            TaskCompletionSource<Main> tcs = new TaskCompletionSource<Main>();

            CreateGObjectAsync((go) =>
            {
                tcs.SetResult(EntityFactory.Create<Main, GObject >(Game.Scene,go));
            });

            return tcs.Task;
        }

        public static Main Create(GObject go)
		{
			return EntityFactory.Create<Main, GObject >(Game.Scene,go);
		}
		
        /// <summary>
        /// 通过此方法获取的FUI，在Dispose时不会释放GObject，需要自行管理（一般在配合FGUI的Pool机制时使用）。
        /// </summary>
        public static Main GetFormPool(GObject go)
        {
            var fui = go.Get<Main>();

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
				BagButton = BagButton.Create(com.GetChild("BagButton"));
				n1 = (GMovieClip)com.GetChild("n1");
				playerView = ItemView.Create(com.GetChild("playerView"));
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
			BagButton.Dispose();
			BagButton = null;
			n1 = null;
			playerView.Dispose();
			playerView = null;
		}
	}
}