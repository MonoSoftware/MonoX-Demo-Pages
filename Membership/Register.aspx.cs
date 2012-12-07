using System;

namespace MonoSoftware.MonoX.Pages
{
    public partial class Register : BasePage
    {
        #region Page Events
        protected override void OnInit(EventArgs e)
        {            
            ctlMembershipEditor.AccountCreationCompleted += new EventHandler(ctlMembership_AccountCreationCompleted);
            if (!ApplicationSettings.EnableUserRegistration)
                Message.Show(Resources.DefaultResources.Registration_RegistrationNotAllowed_Title, Resources.DefaultResources.Registration_RegistrationNotAllowed_Description, ApplicationSettings.MessagePageUrl);
            base.OnInit(e);
        }

        protected override void OnPreRender(EventArgs e)
        {
            //Show acount creation only to non-registered users, for account update they need to go to the Profile page.
            ctlMembershipEditor.Visible = !Page.User.Identity.IsAuthenticated;
            base.OnPreRender(e);
        }
        #endregion

        #region Methods
        void ctlMembership_AccountCreationCompleted(object sender, EventArgs e)
        {
            Message.Show(Resources.DefaultResources.Message_AccountCreated_Title,
                        String.Format(Resources.DefaultResources.Message_AccountCreated_Description, ResolveUrl(ctlMembershipEditor.ActivationEmailRecoveryPageUrl)));
        } 
        #endregion
    }
}
