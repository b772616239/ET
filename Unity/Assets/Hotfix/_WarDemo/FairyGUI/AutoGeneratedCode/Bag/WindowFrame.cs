/** This is an automatically generated class by FairyGUI plugin FGUI2ET. Please do not modify it. **/

using System.Threading.Tasks;
using FairyGUI;
using ETModel;
using ETHotfix;

namespace ETHotfix.Bag
{
    [ObjectSystem]
    public class WindowFrameAwakeSystem : AwakeSystem<WindowFrame, GObject>
    {
        public override void Awake(WindowFrame self, GObject go)
        {
            self.Awake(go);
        }
    }
	
	public sealed class WindowFrame : FUI
	{	
		public const string UIPackageName = "Bag";
		public const string UIResName = "WindowFrame";
		
		/// <summary>
        /// WindowFrame的组件类型(GComponent、GButton、GProcessBar等)，它们都是GObject的子类。
        /// </summary>
		public GComponent self;
		
		public GImage BG;
		public ButtonClose closeButton;
		public GGraph dragArea;

		private static GObject CreateGObject()
        {
            return UIPackage.CreateObject(UIPackageName, UIResName);
        }
		
		private static void CreateGObjectAsync(UIPackage.CreateObjectCallback result)
        {
            UIPackage.CreateObjectAsync(UIPackageName, UIResName, result);
        }

        public static WindowFrame CreateInstance()
		{			
			return EntityFactory.Create<WindowFrame, GObject >(Game.Scene,CreateGObject());
		}

        public static Task<WindowFrame> CreateInstanceAsync()
        {
            TaskCompletionSource<WindowFrame> tcs = new TaskCompletionSource<WindowFrame>();

            CreateGObjectAsync((go) =>
            {
                tcs.SetResult(EntityFactory.Create<WindowFrame, GObject >(Game.Scene,go));
            });

            return tcs.Task;
        }

        public static WindowFrame Create(GObject go)
		{
			return EntityFactory.Create<WindowFrame, GObject >(Game.Scene,go);
		}
		
        /// <summary>
        /// 通过此方法获取的FUI，在Dispose时不会释放GObject，需要自行管理（一般在配合FGUI的Pool机制时使用）。
        /// </summary>
        public static WindowFrame GetFormPool(GObject go)
        {
            var fui = go.Get<WindowFrame>();

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
				BG = (GImage)com.GetChild("BG");
				closeButton = ButtonClose.Create(com.GetChild("closeButton"));
				dragArea = (GGraph)com.GetChild("dragArea");
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
			BG = null;
			closeButton.Dispose();
			closeButton = null;
			dragArea = null;
		}
	}
}