using MonoSoftware.MonoX.Extensions;
using System;

namespace MonoSoftware.MonoX.Pages
{
    public partial class Login : BasePage
    {
        protected override bool AllowAccess()
        {
            //allow access to all users, otherwise we would end up in closed loop since they are redirected here if they are not allowed to log in on some page
            return true;
        }
        protected override void OnPreInit(EventArgs e)
        {            
            if (Request.IsLiveWriterRequest())
                this.MasterPageFile = "~/MonoX/MasterPages/Empty.master";
            base.OnPreInit(e);
        }

        protected override void OnLoad(EventArgs e)
        {            
            ctlLogin.EnableAutoFocus = true;
            plhAuthorizationMessage.Visible = UrlParams.Unauthorized.HasValue;
            ctlLogin.ShowRegisterButton = ApplicationSettings.EnableUserRegistration;
            ctlLoginSocial.Visible = ApplicationSettings.EnableUserRegistration;
            base.OnLoad(e);
        }

    }
}
