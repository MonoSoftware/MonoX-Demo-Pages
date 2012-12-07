using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MonoSoftware.MonoX.Mobile
{
    public partial class Wall : BaseMobilePage
    {
        protected override void OnLoad(EventArgs e)
        {            
            if (!Page.User.Identity.IsAuthenticated)
                Response.Redirect(Paths.MonoX.Mobile.Login_aspx);
            base.OnLoad(e);
        }
    }
}
