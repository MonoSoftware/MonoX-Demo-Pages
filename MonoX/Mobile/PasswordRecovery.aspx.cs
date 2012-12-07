using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MonoSoftware.MonoX.Mobile
{
    public partial class PasswordRecovery : BaseMobilePage
    {
        protected override void OnInit(EventArgs e)
        {            
            ctlPasswordRecovery.PasswordRecoveryEmailSendingCompleted += new EventHandler(ctlPasswordRecovery_PasswordRecoveryEmailSendingCompleted);
            base.OnInit(e);
        }

        void ctlPasswordRecovery_PasswordRecoveryEmailSendingCompleted(object sender, EventArgs e)
        {
            Message.Show(Resources.DefaultResources.Message_PasswordRecoveryEmailSent_Title, Resources.DefaultResources.Message_PasswordRecoveryEmailSent_Description, Paths.MonoX.Mobile.MobileMessage_aspx);
        }

    }
}
