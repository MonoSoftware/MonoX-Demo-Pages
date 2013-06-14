using MonoSoftware.MonoX.BusinessLayer;
using MonoSoftware.MonoX.DAL.EntityClasses;
using MonoSoftware.MonoX.Repositories;
using MonoSoftware.MonoX.Resources;
using MonoSoftware.MonoX.Utilities;
using System;

namespace MonoSoftware.MonoX.Pages.Profile
{
    public partial class AboutMe : BaseProfilePage
    {
        #region Page Events
        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            ctlProfile.Title = PageResources.UserProfile_UserProfile_Title;
            snPeopleSearch.InfoText = PageResources.UserProfile_PeopleSearch_InfoText;
            
            ctlProfile.ShowWorkingModeSwitch = false;            
            snFriendList.Visible = false;
            googleMaps.Visible = false;
            socialDisconnect.Visible = false;
            if (!String.IsNullOrEmpty(UserName) && !Guid.Empty.Equals(UserId))
            {                
                if (CurrentUser != null)
                {
                    if ((SecurityUtility.GetUserId() == CurrentUser.Id) && Page.User.Identity.IsAuthenticated)
                    {
                        ctlProfile.ShowWorkingModeSwitch = true;
                        socialDisconnect.Visible = true;
                    }

                    ctlProfile.UserId = CurrentUser.Id;
                    snFriendList.UserId = CurrentUser.Id;                    
                    snFriendList.Visible = true;
                    snPeopleSearch.UserId = CurrentUser.Id;
                    googleMaps.Visible = true;
                    googleMaps.UserId = CurrentUser.Id;                    
                    socialDisconnect.UserId = CurrentUser.Id;
                    profileHeader.UserId = UserId;
                    profileHeader.DataBind();
                }
            }
            else
            {
                this.SetPageTitle(MonoSoftware.MonoX.Resources.PageResources.UserProfile_NoSuchUser); 
            }            
        }

        protected override void OnPreRender(EventArgs e)
        {            
            snPeopleSearch.SearchBoxVisible = false;
            if (CurrentUser != null)
            {
                string nameToShow = CurrentUser.UserShortDisplayName;
                snFriendList.Title = String.Format(PageResources.Module_UserProfileFriends, nameToShow);
                snPeopleSearch.Title = String.Format(PageResources.UserProfile_PeopleSearch_Title, nameToShow);
                googleMaps.Title = String.Format(PageResources.UserProfile_Map_Title, nameToShow);
                socialDisconnect.Title = DefaultResources.SocialDisconnect_Title;
                this.SetPageTitle(String.Format(MonoSoftware.MonoX.Resources.PageResources.UserProfile_Title, nameToShow));
            }
            base.OnPreRender(e);
        } 

       
        #endregion

    }
}
