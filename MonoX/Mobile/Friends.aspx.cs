using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MonoSoftware.MonoX.Resources;

namespace MonoSoftware.MonoX.Mobile
{
    public partial class Friends : BaseMobilePage
    {
        protected override void OnLoad(EventArgs e)
        {            
            if (!Page.User.Identity.IsAuthenticated)
                Response.Redirect(Paths.MonoX.Mobile.Login_aspx);
            base.OnLoad(e);
        }
    }
}
