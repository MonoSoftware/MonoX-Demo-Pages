using System;
using System.Web.UI.WebControls;

namespace MonoSoftware.MonoX.MasterPages
{
    public partial class UpdatePanel : BaseMasterPage
    {
        protected override void OnInit(EventArgs e)
        {
            this.MainUpdatePanel = ajaxPanelMain;
            base.OnInit(e);
        }

        protected override void OnLoad(EventArgs e)
        {            
            Literal ltlLoading = updateProgressMain.FindControl("ltlLoading") as Literal;
            if (ltlLoading != null)
                ltlLoading.Text = MonoSoftware.MonoX.Resources.DefaultResources.Label_Loading; 
            base.OnLoad(e);
        }
    }
}
