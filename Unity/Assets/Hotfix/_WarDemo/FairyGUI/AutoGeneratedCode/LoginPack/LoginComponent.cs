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
		public bgBtn bgBtn;
		public WindowFrame1 frameReg;
		public Button ConfirmBtn;
		public GTextInput RegAccIn;
		public GTextField n83;
		public GImage n84;
		public GGroup n86;
		public GTextInput RegPWIn;
		public GTextField n88;
		public GImage n89;
		public GGroup n91;
		public GTextInput RegConfirmIn;
		public GTextField n93;
		public GImage n94;
		public GGroup n96;
		public GGroup Register;
		public GGroup Login;
		public WindowFrame1 frameLogin;
		public GGroup n80;
		public GTextInput pwIn;
		public GImage n78;
		public GTextField n77;
		public Button loginBtn;
		public GGroup n53;
		public GTextInput accIn;
		public GImage n51;
		public GTextField n50;
		public Button regBtn;

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
				bgBtn = bgBtn.Create(com.GetChildAt(0));
				frameReg = WindowFrame1.Create(com.GetChildAt(1));
				ConfirmBtn = Button.Create(com.GetChildAt(2));
				RegAccIn = (GTextInput)com.GetChildAt(3);
				n83 = (GTextField)com.GetChildAt(4);
				n84 = (GImage)com.GetChildAt(5);
				n86 = (GGroup)com.GetChildAt(6);
				RegPWIn = (GTextInput)com.GetChildAt(7);
				n88 = (GTextField)com.GetChildAt(8);
				n89 = (GImage)com.GetChildAt(9);
				n91 = (GGroup)com.GetChildAt(10);
				RegConfirmIn = (GTextInput)com.GetChildAt(11);
				n93 = (GTextField)com.GetChildAt(12);
				n94 = (GImage)com.GetChildAt(13);
				n96 = (GGroup)com.GetChildAt(14);
				Register = (GGroup)com.GetChildAt(15);
				Login = (GGroup)com.GetChildAt(16);
				frameLogin = WindowFrame1.Create(com.GetChildAt(17));
				n80 = (GGroup)com.GetChildAt(18);
				pwIn = (GTextInput)com.GetChildAt(19);
				n78 = (GImage)com.GetChildAt(20);
				n77 = (GTextField)com.GetChildAt(21);
				loginBtn = Button.Create(com.GetChildAt(22));
				n53 = (GGroup)com.GetChildAt(23);
				accIn = (GTextInput)com.GetChildAt(24);
				n51 = (GImage)com.GetChildAt(25);
				n50 = (GTextField)com.GetChildAt(26);
				regBtn = Button.Create(com.GetChildAt(27));
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
			bgBtn.Dispose();
			bgBtn = null;
			frameReg.Dispose();
			frameReg = null;
			ConfirmBtn.Dispose();
			ConfirmBtn = null;
			RegAccIn = null;
			n83 = null;
			n84 = null;
			n86 = null;
			RegPWIn = null;
			n88 = null;
			n89 = null;
			n91 = null;
			RegConfirmIn = null;
			n93 = null;
			n94 = null;
			n96 = null;
			Register = null;
			Login = null;
			frameLogin.Dispose();
			frameLogin = null;
			n80 = null;
			pwIn = null;
			n78 = null;
			n77 = null;
			loginBtn.Dispose();
			loginBtn = null;
			n53 = null;
			accIn = null;
			n51 = null;
			n50 = null;
			regBtn.Dispose();
			regBtn = null;
		}
	}
}