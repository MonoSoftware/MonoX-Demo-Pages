using System;
using MonoSoftware.MonoX.Utilities;
using MonoSoftware.Web;

namespace MonoSoftware.MonoX.Mobile
{
    public partial class AccountActivation : MonoSoftware.MonoX.Pages.AccountActivation
    {
        protected override void OnInit(EventArgs e)
        {            
            PageUtility.InjectJQMobileHeaders(this, false, false, this.IsAsyncPostBack());
            this.AccountActivatedMessagePageUrl = "~/MonoX/Mobile/MobileMessage.aspx";
            base.OnInit(e);
        }
    }
}
