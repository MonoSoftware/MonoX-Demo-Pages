using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MonoSoftware.MonoX.Mobile
{
    public partial class ActivationEmailRecovery : BaseMobilePage
    {
        protected override void OnInit(EventArgs e)
        {            
            ctlActivationEmailRecovery.ActivationEmailSendingCompleted += new EventHandler(ctlActivationEmailRecovery_ActivationEmailSendingCompleted);
            base.OnInit(e);
        }

        void ctlActivationEmailRecovery_ActivationEmailSendingCompleted(object sender, EventArgs e)
        {
            Message.Show(Resources.DefaultResources.Message_AccountActivationEmailSent_Title, Resources.DefaultResources.Message_AccountActivationEmailSent_Description, Paths.MonoX.Mobile.MobileMessage_aspx);
        }

    }
}
