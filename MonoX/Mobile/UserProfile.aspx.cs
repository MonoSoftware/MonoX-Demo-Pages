using MonoSoftware.MonoX.BusinessLayer;
using MonoSoftware.MonoX.DAL.EntityClasses;
using MonoSoftware.MonoX.Repositories;
using MonoSoftware.MonoX.Resources;
using MonoSoftware.MonoX.Utilities;
using System;

namespace MonoSoftware.MonoX.Mobile
{
    public partial class UserProfile : BaseMobilePage
    {
        #region Properties
        private UserProfileEntity CurrentUser { get; set; }
        #endregion

        #region Page Events
        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            ctlProfile.Title = PageResources.UserProfile_UserProfile_Title;
            string userName = string.Empty;
            if (UrlParams.UserProfile.UserName.HasValue)
                userName = UrlParams.UserProfile.UserName.Value;
            ctlProfile.ShowWorkingModeSwitch = false;
            Guid userId = SecurityUtility.GetUserId(userName);
            if (!String.IsNullOrEmpty(userName) && !Guid.Empty.Equals(userId))
            {
                this.SetPageTitle(String.Format(MonoSoftware.MonoX.Resources.PageResources.UserProfile_Title, userName));
                CurrentUser = DependencyInjectionFactory.Resolve<IUserProfileBLL>().GetCachedUserProfile(userId);
                if (CurrentUser != null)
                {
                    if ((SecurityUtility.GetUserId() == CurrentUser.Id) && Page.User.Identity.IsAuthenticated)
                        ctlProfile.ShowWorkingModeSwitch = true;

                    ctlProfile.UserId = CurrentUser.Id;
                }
            }
            else
            {
                this.SetPageTitle(MonoSoftware.MonoX.Resources.PageResources.UserProfile_NoSuchUser);
            }            
        }


        #endregion

    }
}
