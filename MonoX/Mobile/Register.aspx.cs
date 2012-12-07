using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MonoSoftware.MonoX.Mobile
{
    public partial class Register : BaseMobilePage
    {
        protected override void OnInit(EventArgs e)
        {            
            ctlMembershipEditor.AccountCreationCompleted += new EventHandler(ctlMembership_AccountCreationCompleted);
            if (!ApplicationSettings.EnableUserRegistration)
                MobileMessage.Show(Resources.DefaultResources.Registration_RegistrationNotAllowed_Title, Resources.DefaultResources.Registration_RegistrationNotAllowed_Description, Paths.MonoX.Mobile.MobileMessage_aspx);
            base.OnInit(e);
        }

        protected override void OnPreRender(EventArgs e)
        {
            //Show acount creation only to non-registered users, for account update they need to go to the Profile page.
            ctlMembershipEditor.Visible = !Page.User.Identity.IsAuthenticated;
            base.OnPreRender(e);
        }

        void ctlMembership_AccountCreationCompleted(object sender, EventArgs e)
        {
            MobileMessage.Show(Resources.DefaultResources.Message_AccountCreated_Title,
                        String.Format(Resources.DefaultResources.Message_AccountCreated_Description, ResolveUrl(ctlMembershipEditor.ActivationEmailRecoveryPageUrl)), Paths.MonoX.Mobile.MobileMessage_aspx);
        } 
    }
}
