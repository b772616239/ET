/** This is an automatically generated class by FairyGUI plugin FGUI2ET. Please do not modify it. **/

using System.Threading.Tasks;
using FairyGUI;
using ETModel;
using ETHotfix;

namespace ETHotfix.LoginPack
{
    [ObjectSystem]
    public class WindowFrame1AwakeSystem : AwakeSystem<WindowFrame1, GObject>
    {
        public override void Awake(WindowFrame1 self, GObject go)
        {
            self.Awake(go);
        }
    }
	
	public sealed class WindowFrame1 : FUI
	{	
		public const string UIPackageName = "LoginPack";
		public const string UIResName = "WindowFrame1";
		
		/// <summary>
        /// WindowFrame1的组件类型(GComponent、GButton、GProcessBar等)，它们都是GObject的子类。
        /// </summary>
		public GLabel self;
		
		public GImage n0;
		public GTextField title;
		public GLoader icon;
		public GGraph dragArea;
		public GGraph contentArea;

		private static GObject CreateGObject()
        {
            return UIPackage.CreateObject(UIPackageName, UIResName);
        }
		
		private static void CreateGObjectAsync(UIPackage.CreateObjectCallback result)
        {
            UIPackage.CreateObjectAsync(UIPackageName, UIResName, result);
        }

        public static WindowFrame1 CreateInstance()
		{			
			return EntityFactory.Create<WindowFrame1, GObject >(Game.Scene,CreateGObject());
		}

        public static Task<WindowFrame1> CreateInstanceAsync()
        {
            TaskCompletionSource<WindowFrame1> tcs = new TaskCompletionSource<WindowFrame1>();

            CreateGObjectAsync((go) =>
            {
                tcs.SetResult(EntityFactory.Create<WindowFrame1, GObject >(Game.Scene,go));
            });

            return tcs.Task;
        }

        public static WindowFrame1 Create(GObject go)
		{
			return EntityFactory.Create<WindowFrame1, GObject >(Game.Scene,go);
		}
		
        /// <summary>
        /// 通过此方法获取的FUI，在Dispose时不会释放GObject，需要自行管理（一般在配合FGUI的Pool机制时使用）。
        /// </summary>
        public static WindowFrame1 GetFormPool(GObject go)
        {
            var fui = go.Get<WindowFrame1>();

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
			
			self = (GLabel)go;
			
			self.Add(this);
			
			var com = go.asCom;
				
			if(com != null)
			{	
				n0 = (GImage)com.GetChildAt(0);
				title = (GTextField)com.GetChildAt(1);
				icon = (GLoader)com.GetChildAt(2);
				dragArea = (GGraph)com.GetChildAt(3);
				contentArea = (GGraph)com.GetChildAt(4);
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
			n0 = null;
			title = null;
			icon = null;
			dragArea = null;
			contentArea = null;
		}
	}
}