/** This is an automatically generated class by FairyGUI plugin FGUI2ET. Please do not modify it. **/

using System.Threading.Tasks;
using FairyGUI;
using ETModel;
using ETHotfix;

namespace ETHotfix.Joystick
{
    [ObjectSystem]
    public class CircleAwakeSystem : AwakeSystem<Circle, GObject>
    {
        public override void Awake(Circle self, GObject go)
        {
            self.Awake(go);
        }
    }
	
	public sealed class Circle : FUI
	{	
		public const string UIPackageName = "Joystick";
		public const string UIResName = "Circle";
		
		/// <summary>
        /// Circle的组件类型(GComponent、GButton、GProcessBar等)，它们都是GObject的子类。
        /// </summary>
		public GButton self;
		
		public Controller button;
		public GImage thumb;

		private static GObject CreateGObject()
        {
            return UIPackage.CreateObject(UIPackageName, UIResName);
        }
		
		private static void CreateGObjectAsync(UIPackage.CreateObjectCallback result)
        {
            UIPackage.CreateObjectAsync(UIPackageName, UIResName, result);
        }

        public static Circle CreateInstance()
		{			
			return EntityFactory.Create<Circle, GObject >(Game.Scene,CreateGObject());
		}

        public static Task<Circle> CreateInstanceAsync()
        {
            TaskCompletionSource<Circle> tcs = new TaskCompletionSource<Circle>();

            CreateGObjectAsync((go) =>
            {
                tcs.SetResult(EntityFactory.Create<Circle, GObject >(Game.Scene,go));
            });

            return tcs.Task;
        }

        public static Circle Create(GObject go)
		{
			return EntityFactory.Create<Circle, GObject >(Game.Scene,go);
		}
		
        /// <summary>
        /// 通过此方法获取的FUI，在Dispose时不会释放GObject，需要自行管理（一般在配合FGUI的Pool机制时使用）。
        /// </summary>
        public static Circle GetFormPool(GObject go)
        {
            var fui = go.Get<Circle>();

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
				thumb = (GImage)com.GetChild("thumb");
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
			thumb = null;
		}
	}
}