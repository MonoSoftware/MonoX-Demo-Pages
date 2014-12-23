using System;
using MonoSoftware.MonoX.Utilities;
using MonoSoftware.Web;

namespace MonoSoftware.MonoX.Mobile
{
    public partial class AccountActivation : MonoSoftware.MonoX.Pages.AccountActivation
    {
        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            PageUtility.InjectJQMobileHeaders(this, false, false, this.IsAsyncPostBack());
            this.AccountActivatedMessagePageUrl = Paths.MonoX.Mobile.MobileMessage_aspx;            
        }
    }
}
