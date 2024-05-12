/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using Cysharp.Threading.Tasks;
using FairyGUI.Utils;
using GameFrameX.Entity.Runtime;
using GameFrameX.FairyGUI.Runtime;
using GameFrameX.Runtime;

namespace Hotfix.UI
{
    public sealed partial class UIPlayerListItem : FUI
    {
        public const string UIPackageName = "UILogin";
        public const string UIResName = "UIPlayerListItem";
        public const string URL = "ui://f011l0h9i3dbs9n";

        /// <summary>
        /// {uiResName}的组件类型(GComponent、GButton、GProcessBar等)，它们都是GObject的子类。
        /// </summary>
        public GComponent self { get; private set; }

		public GLoader m_icon { get; private set; }
		public GRichTextField m_name_text { get; private set; }
		public GRichTextField m_level_text { get; private set; }
		public GComponent m_login_button { get; private set; }

        private static GObject CreateGObject()
        {
            return UIPackage.CreateObject(UIPackageName, UIResName);
        }

        private static void CreateGObjectAsync(UIPackage.CreateObjectCallback result)
        {
            UIPackage.CreateObjectAsync(UIPackageName, UIResName, result);
        }

        public static UIPlayerListItem CreateInstance(object userData = null)
        {
            return new UIPlayerListItem(CreateGObject(), userData);
        }

        public static UniTask<UIPlayerListItem> CreateInstanceAsync(Entity domain, object userData = null)
        {
            UniTaskCompletionSource<UIPlayerListItem> tcs = new UniTaskCompletionSource<UIPlayerListItem>();
            CreateGObjectAsync((go) =>
            {
                tcs.TrySetResult(new UIPlayerListItem(go, userData));
            });
            return tcs.Task;
        }

        public static UIPlayerListItem Create(GObject go, object userData = null)
        {
            return new UIPlayerListItem(go, userData);
        }

        /// <summary>
        /// 通过此方法获取的FUI，在Dispose时不会释放GObject，需要自行管理（一般在配合FGUI的Pool机制时使用）。
        /// </summary>
        public static UIPlayerListItem GetFormPool(GObject go)
        {
            var fui =  go.Get<UIPlayerListItem>();
            if(fui == null)
            {
                fui = Create(go);
            }
            fui.IsFromPool = true;
            return fui;
        }

        protected override void InitView()
        {
            if(GObject == null)
            {
                return;
            }

            self = (GComponent)GObject;
            self.Add(this);
            
            var com = GObject.asCom;
            if(com != null)
            {
				m_icon = (GLoader)com.GetChild("icon");
				m_name_text = (GRichTextField)com.GetChild("name_text");
				m_level_text = (GRichTextField)com.GetChild("level_text");
				m_login_button = (GComponent)com.GetChild("login_button");
            }
        }

        public override void Dispose()
        {
            if (IsDisposed)
            {
                return;
            }

            base.Dispose();
            self.Remove();
			m_icon = null;
			m_name_text = null;
			m_level_text = null;
			m_login_button = null;
            self = null;            
        }

        private UIPlayerListItem(GObject gObject, object userData) : base(gObject, userData)
        {
            // Awake(gObject);
        }
    }
}