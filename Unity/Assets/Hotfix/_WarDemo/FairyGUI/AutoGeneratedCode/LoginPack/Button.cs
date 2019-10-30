/** This is an automatically generated class by FairyGUI plugin FGUI2ET. Please do not modify it. **/

using System.Threading.Tasks;
using FairyGUI;
using ETModel;
using ETHotfix;

namespace ETHotfix.LoginPack
{
    [ObjectSystem]
    public class ButtonAwakeSystem : AwakeSystem<Button, GObject>
    {
        public override void Awake(Button self, GObject go)
        {
            self.Awake(go);
        }
    }
	
	public sealed class Button : FUI
	{	
		public const string UIPackageName = "LoginPack";
		public const string UIResName = "Button";
		
		/// <summary>
        /// Button的组件类型(GComponent、GButton、GProcessBar等)，它们都是GObject的子类。
        /// </summary>
		public GButton self;
		
		public Controller button;
		public GImage n0;
		public GImage n1;
		public GTextField title;

		private static GObject CreateGObject()
        {
            return UIPackage.CreateObject(UIPackageName, UIResName);
        }
		
		private static void CreateGObjectAsync(UIPackage.CreateObjectCallback result)
        {
            UIPackage.CreateObjectAsync(UIPackageName, UIResName, result);
        }

        public static Button CreateInstance()
		{			
			return EntityFactory.Create<Button, GObject >(Game.Scene,CreateGObject());
		}

        public static Task<Button> CreateInstanceAsync()
        {
            TaskCompletionSource<Button> tcs = new TaskCompletionSource<Button>();

            CreateGObjectAsync((go) =>
            {
                tcs.SetResult(EntityFactory.Create<Button, GObject >(Game.Scene,go));
            });

            return tcs.Task;
        }

        public static Button Create(GObject go)
		{
			return EntityFactory.Create<Button, GObject >(Game.Scene,go);
		}
		
        /// <summary>
        /// 通过此方法获取的FUI，在Dispose时不会释放GObject，需要自行管理（一般在配合FGUI的Pool机制时使用）。
        /// </summary>
        public static Button GetFormPool(GObject go)
        {
            var fui = go.Get<Button>();

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
				button = com.GetControllerAt(0);
				n0 = (GImage)com.GetChildAt(0);
				n1 = (GImage)com.GetChildAt(1);
				title = (GTextField)com.GetChildAt(2);
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
			n0 = null;
			n1 = null;
			title = null;
		}
	}
}