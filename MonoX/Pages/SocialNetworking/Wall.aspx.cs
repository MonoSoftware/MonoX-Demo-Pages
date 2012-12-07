using MonoSoftware.MonoX.Resources;
using System;
namespace MonoSoftware.MonoX.Pages.SocialNetworking
{
    public partial class Wall : BasePage
    {
        protected override void OnPreInit(EventArgs e)
        {
            this.AjaxifiedPage = true;
            base.OnPreInit(e);
        }

        protected override void OnInit(EventArgs e)
        {            
            this.SetPageTitle(PageResources.Wall_Title);
            snWallNotes.Title = PageResources.Module_WallNotes;
            snPeopleSearch.Title = PageResources.Module_PeopleSearch;
            snFriendList.Title = PageResources.Module_Friends;
            ctlInvitationsReceived.Title = PageResources.Module_InvitationsReceived;
            ctlInvitationsSent.Title = PageResources.Module_InvitationsSent;
            base.OnInit(e);
        }
    }
}
