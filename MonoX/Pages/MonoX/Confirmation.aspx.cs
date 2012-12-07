using System;

namespace MonoSoftware.MonoX.Pages
{
    public partial class Confirmation : BasePage
    {
        protected override void OnLoad(EventArgs e)
        {            
            ctlConfirmation.Title = MonoSoftware.MonoX.Resources.PageResources.Confirmation_Title;
            base.OnLoad(e);
        }
    }
}
