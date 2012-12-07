using MonoSoftware.MonoX.BusinessLayer;
using MonoSoftware.MonoX.DAL.EntityClasses;
using MonoSoftware.MonoX.Repositories;
using MonoSoftware.MonoX.Resources;
using MonoSoftware.MonoX.Utilities;
using System;

namespace MonoSoftware.MonoX.Pages.SocialNetworking
{
    public partial class UserProfile : BasePage
    {
        #region Properties
        private UserProfileEntity CurrentUser { get; set; }
        #endregion

        #region Page Events
        protected override void OnInit(EventArgs e)
        {            
            ctlProfile.MyStatusChanged += new EventHandler(ctlProfile_MyStatusChanged);
            ctlProfile.Title = PageResources.UserProfile_UserProfile_Title;
            snPeopleSearch.InfoText = PageResources.UserProfile_PeopleSearch_InfoText;
            ctlInvitationsReceived.Title = PageResources.Module_InvitationsReceived;
            ctlInvitationsSent.Title = PageResources.Module_InvitationsSent;
            
            string userName = string.Empty;
            if (UrlParams.UserProfile.UserName.HasValue)
                userName = MonoSoftware.Web.UrlEncoder.UrlDecode(UrlParams.UserProfile.UserName.Value);
            ctlProfile.ShowWorkingModeSwitch = false;
            Guid userId = SecurityUtility.GetUserId(userName);
            snFriendList.Visible = false;
            snWallNotes.Visible = false;
            discussionTopicMessages.Visible = false;
            ctlInvitationsSent.Visible = false;
            ctlInvitationsReceived.Visible = false;
            if (!String.IsNullOrEmpty(userName) && !Guid.Empty.Equals(userId))
            {
                snPeopleSearch.Title = string.Format(PageResources.UserProfile_PeopleSearch_Title, userName);
                snWallNotes.Title = String.Format(PageResources.Module_WallNotes, userName);
                this.SetPageTitle(String.Format(MonoSoftware.MonoX.Resources.PageResources.UserProfile_Title, userName));
                CurrentUser = UserProfileBLL.GetInstance().GetCachedUserProfile(userId);
                if (CurrentUser != null)
                {
                    string nameToShow = (CurrentUser != null && !string.IsNullOrEmpty(CurrentUser.FirstName)? CurrentUser.FirstName : CurrentUser.AspnetUser.UserName);                        
                    snFriendList.Title = String.Format(PageResources.Module_UserProfileFriends, nameToShow);
                    discussionTopicMessages.Title = PageResources.UserProfile_DiscussionMessages_Title;

                    if ((SecurityUtility.GetUserId() == CurrentUser.Id) && Page.User.Identity.IsAuthenticated)
                        ctlProfile.ShowWorkingModeSwitch = true;

                    ctlProfile.UserId = CurrentUser.Id;
                    ctlInvitationsSent.UserId = CurrentUser.Id;
                    ctlInvitationsReceived.UserId = CurrentUser.Id;
                    snFriendList.UserId = CurrentUser.Id;                    
                    snFriendList.Visible = true;
                    discussionTopicMessages.UserId = CurrentUser.Id;
                    discussionTopicMessages.Visible = true;
                    discussionTopicMessages.BindData();
                    snWallNotes.UserId = CurrentUser.Id;
                    snWallNotes.Visible = true;
                    snPeopleSearch.UserId = CurrentUser.Id;
                }
            }
            else
            {
                this.SetPageTitle(MonoSoftware.MonoX.Resources.PageResources.UserProfile_NoSuchUser); 
            }
            base.OnInit(e);
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
            base.OnPreRender(e);
        } 

       
        #endregion

        #region Methods
        void ctlProfile_MyStatusChanged(object sender, EventArgs e)
        {
            snWallNotes.BindData();
        }
        #endregion
    }
}
