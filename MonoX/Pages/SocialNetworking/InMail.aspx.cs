using MonoSoftware.MonoX.Resources;
using System;

namespace MonoSoftware.MonoX.Pages.SocialNetworking
{
    public partial class InMail : BasePage
    {
        protected override void OnInit(EventArgs e)
        {            
            this.SetPageTitle(MonoSoftware.MonoX.Resources.PageResources.Messages_Title);
            messageList.Title = PageResources.Module_Messages;
            base.OnInit(e);
        }
    }
}
