/** This is an automatically generated class by FairyGUI plugin FGUI2ET. Please do not modify it. **/

using System.Threading.Tasks;
using FairyGUI;
using ETModel;
using ETHotfix;

namespace ETHotfix.DialogPack
{
    [ObjectSystem]
    public class DialogComponentAwakeSystem : AwakeSystem<DialogComponent, GObject>
    {
        public override void Awake(DialogComponent self, GObject go)
        {
            self.Awake(go);
        }
    }
	
	public sealed class DialogComponent : FUI
	{	
		public const string UIPackageName = "DialogPack";
		public const string UIResName = "DialogComponent";
		
		/// <summary>
        /// DialogComponent的组件类型(GComponent、GButton、GProcessBar等)，它们都是GObject的子类。
        /// </summary>
		public GComponent self;
		
		public GImage greenBg;
		public GImage WinBg;
		public GImage SimpleBg;
		public GTextField content;
		public GGroup n13;

		private static GObject CreateGObject()
        {
            return UIPackage.CreateObject(UIPackageName, UIResName);
        }
		
		private static void CreateGObjectAsync(UIPackage.CreateObjectCallback result)
        {
            UIPackage.CreateObjectAsync(UIPackageName, UIResName, result);
        }

        public static DialogComponent CreateInstance()
		{			
			return EntityFactory.Create<DialogComponent, GObject >(Game.Scene,CreateGObject());
		}

        public static Task<DialogComponent> CreateInstanceAsync()
        {
            TaskCompletionSource<DialogComponent> tcs = new TaskCompletionSource<DialogComponent>();

            CreateGObjectAsync((go) =>
            {
                tcs.SetResult(EntityFactory.Create<DialogComponent, GObject >(Game.Scene,go));
            });

            return tcs.Task;
        }

        public static DialogComponent Create(GObject go)
		{
			return EntityFactory.Create<DialogComponent, GObject >(Game.Scene,go);
		}
		
        /// <summary>
        /// 通过此方法获取的FUI，在Dispose时不会释放GObject，需要自行管理（一般在配合FGUI的Pool机制时使用）。
        /// </summary>
        public static DialogComponent GetFormPool(GObject go)
        {
            var fui = go.Get<DialogComponent>();

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
				greenBg = (GImage)com.GetChildAt(0);
				WinBg = (GImage)com.GetChildAt(1);
				SimpleBg = (GImage)com.GetChildAt(2);
				content = (GTextField)com.GetChildAt(3);
				n13 = (GGroup)com.GetChildAt(4);
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
			greenBg = null;
			WinBg = null;
			SimpleBg = null;
			content = null;
			n13 = null;
		}
	}
}