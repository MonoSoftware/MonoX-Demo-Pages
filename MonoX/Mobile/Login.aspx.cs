using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MonoSoftware.MonoX.Mobile
{
    public partial class Login : BaseMobilePage
    {
        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            ctlLogin.DestinationPageUrl = Paths.MonoX.Mobile.Default_aspx;            
        }
    }
}
