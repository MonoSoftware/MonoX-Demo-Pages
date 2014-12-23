using System;

namespace MonoSoftware.MonoX.Pages
{
    public partial class PasswordRecovery : BasePage
    {
        #region Page Events
        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            ctlPasswordRecovery.PasswordRecoveryEmailSendingCompleted += new EventHandler(ctlPasswordRecovery_PasswordRecoveryEmailSendingCompleted);
            ctlPasswordRecovery.PasswordRecoveryRequestEmailSending += new System.ComponentModel.CancelEventHandler(ctlPasswordRecovery_PasswordRecoveryRequestEmailSending);            
        } 
        #endregion

        #region Methods
        void ctlPasswordRecovery_PasswordRecoveryRequestEmailSending(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        void ctlPasswordRecovery_PasswordRecoveryEmailSendingCompleted(object sender, EventArgs e)
        {
            Message.Show(Resources.DefaultResources.Message_PasswordRecoveryEmailSent_Title, Resources.DefaultResources.Message_PasswordRecoveryEmailSent_Description);
        } 
        #endregion
    }
}
