using System;
using MonoSoftware.MonoX.Utilities;
using MonoSoftware.Web;

namespace MonoSoftware.MonoX.Mobile
{
    public partial class MobileMessage : Message
    {
        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            PageUtility.InjectJQMobileHeaders(this, false, false, this.IsAsyncPostBack());            
        }
    }
}
