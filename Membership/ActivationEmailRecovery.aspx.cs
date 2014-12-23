using System;

namespace MonoSoftware.MonoX.Pages
{
    public partial class ActivationEmailRecovery : BasePage
    {
        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            ctlActivationEmailRecovery.ActivationEmailSendingCompleted += new EventHandler(ctlActivationEmailRecovery_ActivationEmailSendingCompleted);            
        }

        void ctlActivationEmailRecovery_ActivationEmailSendingCompleted(object sender, EventArgs e)
        {
            Message.Show(Resources.DefaultResources.Message_AccountActivationEmailSent_Title, Resources.DefaultResources.Message_AccountActivationEmailSent_Description);
        }
    }
}
