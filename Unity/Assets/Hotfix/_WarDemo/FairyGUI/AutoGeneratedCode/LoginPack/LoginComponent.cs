/** This is an automatically generated class by FairyGUI plugin FGUI2ET. Please do not modify it. **/

using System.Threading.Tasks;
using FairyGUI;
using ETModel;
using ETHotfix;

namespace ETHotfix.LoginPack
{
    [ObjectSystem]
    public class LoginComponentAwakeSystem : AwakeSystem<LoginComponent, GObject>
    {
        public override void Awake(LoginComponent self, GObject go)
        {
            self.Awake(go);
        }
    }
	
	public sealed class LoginComponent : FUI
	{	
		public const string UIPackageName = "LoginPack";
		public const string UIResName = "LoginComponent";
		
		/// <summary>
        /// LoginComponent的组件类型(GComponent、GButton、GProcessBar等)，它们都是GObject的子类。
        /// </summary>
		public GComponent self;
		
		public Controller login2RegisterController;
		public GImage n0;
		public GImage n27;
		public Button n25;
		public GTextField n50;
		public GImage n51;
		public GTextInput n52;
		public GGroup n53;
		public Button n58;
		public GTextField n77;
		public GImage n78;
		public GTextInput n79;
		public GGroup n80;
		public GGroup Login;
		public GImage n81;
		public Button n82;
		public GTextField n83;
		public GImage n84;
		public GTextInput n85;
		public GGroup n86;
		public GTextField n88;
		public GImage n89;
		public GTextInput n90;
		public GGroup n91;
		public GTextField n93;
		public GImage n94;
		public GTextInput n95;
		public GGroup n96;
		public GGroup Register;

		private static GObject CreateGObject()
        {
            return UIPackage.CreateObject(UIPackageName, UIResName);
        }
		
		private static void CreateGObjectAsync(UIPackage.CreateObjectCallback result)
        {
            UIPackage.CreateObjectAsync(UIPackageName, UIResName, result);
        }

        public static LoginComponent CreateInstance()
		{			
			return EntityFactory.Create<LoginComponent, GObject >(Game.Scene,CreateGObject());
		}

        public static Task<LoginComponent> CreateInstanceAsync()
        {
            TaskCompletionSource<LoginComponent> tcs = new TaskCompletionSource<LoginComponent>();

            CreateGObjectAsync((go) =>
            {
                tcs.SetResult(EntityFactory.Create<LoginComponent, GObject >(Game.Scene,go));
            });

            return tcs.Task;
        }

        public static LoginComponent Create(GObject go)
		{
			return EntityFactory.Create<LoginComponent, GObject >(Game.Scene,go);
		}
		
        /// <summary>
        /// 通过此方法获取的FUI，在Dispose时不会释放GObject，需要自行管理（一般在配合FGUI的Pool机制时使用）。
        /// </summary>
        public static LoginComponent GetFormPool(GObject go)
        {
            var fui = go.Get<LoginComponent>();

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
				login2RegisterController = com.GetControllerAt(0);
				n0 = (GImage)com.GetChildAt(0);
				n27 = (GImage)com.GetChildAt(1);
				n25 = Button.Create(com.GetChildAt(2));
				n50 = (GTextField)com.GetChildAt(3);
				n51 = (GImage)com.GetChildAt(4);
				n52 = (GTextInput)com.GetChildAt(5);
				n53 = (GGroup)com.GetChildAt(6);
				n58 = Button.Create(com.GetChildAt(7));
				n77 = (GTextField)com.GetChildAt(8);
				n78 = (GImage)com.GetChildAt(9);
				n79 = (GTextInput)com.GetChildAt(10);
				n80 = (GGroup)com.GetChildAt(11);
				Login = (GGroup)com.GetChildAt(12);
				n81 = (GImage)com.GetChildAt(13);
				n82 = Button.Create(com.GetChildAt(14));
				n83 = (GTextField)com.GetChildAt(15);
				n84 = (GImage)com.GetChildAt(16);
				n85 = (GTextInput)com.GetChildAt(17);
				n86 = (GGroup)com.GetChildAt(18);
				n88 = (GTextField)com.GetChildAt(19);
				n89 = (GImage)com.GetChildAt(20);
				n90 = (GTextInput)com.GetChildAt(21);
				n91 = (GGroup)com.GetChildAt(22);
				n93 = (GTextField)com.GetChildAt(23);
				n94 = (GImage)com.GetChildAt(24);
				n95 = (GTextInput)com.GetChildAt(25);
				n96 = (GGroup)com.GetChildAt(26);
				Register = (GGroup)com.GetChildAt(27);
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
			login2RegisterController = null;
			n0 = null;
			n27 = null;
			n25.Dispose();
			n25 = null;
			n50 = null;
			n51 = null;
			n52 = null;
			n53 = null;
			n58.Dispose();
			n58 = null;
			n77 = null;
			n78 = null;
			n79 = null;
			n80 = null;
			Login = null;
			n81 = null;
			n82.Dispose();
			n82 = null;
			n83 = null;
			n84 = null;
			n85 = null;
			n86 = null;
			n88 = null;
			n89 = null;
			n90 = null;
			n91 = null;
			n93 = null;
			n94 = null;
			n95 = null;
			n96 = null;
			Register = null;
		}
	}
}