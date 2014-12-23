using System;

namespace MonoSoftware.MonoX.Pages.SocialNetworking
{
    public partial class Discussion : BasePage
    {
        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            this.SetPageTitle(MonoSoftware.MonoX.Resources.PageResources.Discussion_Title);
            discussion.Title = MonoSoftware.MonoX.Resources.PageResources.Discussion_Title;            
        }
    }
}
