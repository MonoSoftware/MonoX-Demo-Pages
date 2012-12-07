using MonoSoftware.MonoX.BusinessLayer;
using MonoSoftware.MonoX.DAL.EntityClasses;
using MonoSoftware.MonoX.Repositories;
using MonoSoftware.MonoX.Resources;
using MonoSoftware.MonoX.Utilities;
using System;

namespace MonoSoftware.MonoX.Pages.Profile
{
    public partial class MyFriends : BaseProfilePage
    {
        #region Page Events
        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            snPeopleSearch.InfoText = PageResources.UserProfile_PeopleSearch_InfoText;
            ctlInvitationsReceived.Title = PageResources.Module_InvitationsReceived;
            ctlInvitationsSent.Title = PageResources.Module_InvitationsSent;
            ctlInvitationsReceived.Caption = PageResources.Module_InvitationsReceived;
            ctlInvitationsSent.Caption = PageResources.Module_InvitationsSent;
            ctlBlockedUserList.Title = PageResources.Module_BlockedUsersList;
            ctlBlockUser.Title = PageResources.Module_BlockUser;

            ctlBlockUser.Visible = false;
            ctlBlockedUserList.Visible = false;
            snFriendList.Visible = false;
            ctlInvitationsSent.Visible = false;
            ctlInvitationsReceived.Visible = false;
            if (!String.IsNullOrEmpty(UserName) && !Guid.Empty.Equals(UserId))
            {
                if (CurrentUser != null)
                {
                    ctlInvitationsSent.UserId = CurrentUser.Id;
                    ctlInvitationsReceived.UserId = CurrentUser.Id;

                    friendSuggestionsList.UserId = CurrentUser.Id;
                    friendSuggestionsList.BindData();
                    snFriendList.UserId = CurrentUser.Id;                    
                    snFriendList.Visible = true;
                    snPeopleSearch.UserId = CurrentUser.Id;
                    profileHeader.UserId = UserId;
                    profileHeader.DataBind();
                    ctlBlockedUserList.Visible = CurrentUser.Id.Equals(SecurityUtility.GetUserId());
                    ctlBlockedUserList.UserId = CurrentUser.Id;
                    ctlBlockUser.Visible = CurrentUser.Id.Equals(SecurityUtility.GetUserId());                    
                }
            }
            else
            {
                this.SetPageTitle(MonoSoftware.MonoX.Resources.PageResources.UserProfile_NoSuchUser); 
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            if (CurrentUser != null)
            {
                ctlInvitationsSent.Visible = CurrentUser.Id.Equals(SecurityUtility.GetUserId());
                ctlInvitationsReceived.Visible = CurrentUser.Id.Equals(SecurityUtility.GetUserId());
            }
            base.OnLoad(e);
        }

        protected override void OnPreRender(EventArgs e)
        {            
            snPeopleSearch.SearchBoxVisible = false;
            friendSuggestionsList.Visible = (CurrentUser != null && SecurityUtility.GetUserId().Equals(CurrentUser.Id)) || SecurityUtility.IsAdmin();
            if (CurrentUser != null)
            {
                string nameToShow = CurrentUser.UserShortDisplayName;
                snFriendList.Title = String.Format(PageResources.Module_UserProfileFriends, nameToShow);
                snPeopleSearch.Title = String.Format(PageResources.UserProfile_PeopleSearch_Title, nameToShow);
                friendSuggestionsList.Title = PageResources.UserProfile_FriendSuggestion_Title;
                this.SetPageTitle(String.Format(MonoSoftware.MonoX.Resources.PageResources.UserProfile_Title, nameToShow));
            }
            base.OnPreRender(e);
        } 

       
        #endregion

    }
}
