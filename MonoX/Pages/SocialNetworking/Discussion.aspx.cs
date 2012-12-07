using System;

namespace MonoSoftware.MonoX.Pages.SocialNetworking
{
    public partial class Discussion : BasePage
    {
        protected override void OnInit(EventArgs e)
        {            
            this.SetPageTitle(MonoSoftware.MonoX.Resources.PageResources.Discussion_Title);
            discussion.Title = MonoSoftware.MonoX.Resources.PageResources.Discussion_Title;
            base.OnInit(e);
        }
    }
}
