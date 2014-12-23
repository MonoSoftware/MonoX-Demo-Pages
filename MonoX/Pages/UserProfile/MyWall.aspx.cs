using MonoSoftware.MonoX.Resources;
using System;
using MonoSoftware.MonoX.BusinessLayer;
using MonoSoftware.MonoX.Utilities;
using MonoSoftware.MonoX.Repositories;
using MonoSoftware.Web;
using MonoSoftware.MonoX.Common.DependencyInjection;
namespace MonoSoftware.MonoX.Pages.Profile
{
    public partial class MyWall : BaseProfilePage
    {
        #region Page Events
        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            if (!Page.User.Identity.IsAuthenticated)
                Response.Redirect(MonoSoftware.MonoX.Utilities.LocalizationUtility.RewriteLink(UrlFormatter.ResolveServerUrl(RewrittenUrlBuilder.UserProfile.GetUserProfileUrl(RewrittenPaths.ProfileAbout.UrlPattern, Server.UrlEncode(UserName), String.Empty).Url)));

            this.SetPageTitle(PageResources.MyWall_Title);
            snWallNotes.Title = PageResources.Module_WallNotes;
            snPeopleSearch.Title = PageResources.Module_PeopleSearch;
            discussionTopicMessages.Title = PageResources.UserProfile_DiscussionMessages_Title;

            profileHeader.MyStatusChanged += new EventHandler(profileHeader_MyStatusChanged);

            snWallNotes.Visible = false;
            myPhotos.Visible = false;
            snFriendList.Visible = false;
            googleMaps.Visible = false;
            discussionTopicMessages.Visible = false;
            recentPhotos.Visible = false;
            if (!String.IsNullOrEmpty(UserName) && !Guid.Empty.Equals(UserId))
            {
                if (CurrentUser != null)
                {
                    snWallNotes.UserId = CurrentUser.Id;
                    snWallNotes.Visible = true;
                    snPeopleSearch.UserId = CurrentUser.Id;
                    snFriendList.UserId = CurrentUser.Id;
                    snFriendList.Visible = true;
                    myPhotos.UserId = CurrentUser.Id;
                    myPhotos.Visible = true;
                    myPhotos.PhotoGalleryUrl = Paths.MonoX.Pages.UserProfile.MyPhotos_aspx.Append(UrlParams.UserProfile.UserName, Server.UrlEncode(UserName));
                    myPhotos.DataBind();
                    googleMaps.Visible = true;
                    googleMaps.UserId = CurrentUser.Id;
                    discussionTopicMessages.UserId = CurrentUser.Id;
                    discussionTopicMessages.Visible = true;
                    discussionTopicMessages.BindData();
                    profileHeader.UserId = UserId;
                    profileHeader.DataBind();
                    recentPhotos.Visible = true;
                    recentPhotos.UserId = UserId;
                    recentPhotos.BindData();
                }
            }
            else
            {
                this.SetPageTitle(MonoSoftware.MonoX.Resources.PageResources.UserProfile_NoSuchUser);
            }
        }

        protected override void OnPreRender(EventArgs e)
        {
            snWallNotes.AllowPostingNotes = false;
            snPeopleSearch.SearchBoxVisible = false;
            if (CurrentUser != null)
            {
                string nameToShow = CurrentUser.UserShortDisplayName;
                snFriendList.Title = String.Format(PageResources.Module_UserProfileFriends, nameToShow);
                snPeopleSearch.Title = string.Format(PageResources.UserProfile_PeopleSearch_Title, nameToShow);
                snWallNotes.Title = String.Format(PageResources.Module_WallNotes, nameToShow);
                googleMaps.Title = String.Format(PageResources.UserProfile_Map_Title, nameToShow);
                myPhotos.Title = String.Format(PageResources.Module_UserProfilePhotos, nameToShow);
                snWallNotes.AllowPostingNotes = Page.User.Identity.IsAuthenticated && (DependencyInjectionFactory.Resolve<IFriendBLL>().RelationshipExists(SecurityUtility.GetUserId(), CurrentUser.Id) || SecurityUtility.GetUserId().Equals(CurrentUser.Id)) && !DependencyInjectionFactory.Resolve<IFriendBLL>().IsUserBlocked(CurrentUser.Id, SecurityUtility.GetUserId()); 
                this.SetPageTitle(String.Format(MonoSoftware.MonoX.Resources.PageResources.UserProfile_Title, nameToShow));                
            }
            base.OnPreRender(e);
        } 
        #endregion

        #region UI Events
        void profileHeader_MyStatusChanged(object sender, EventArgs e)
        {
            snWallNotes.BindData();
        } 
        #endregion
    }
}
