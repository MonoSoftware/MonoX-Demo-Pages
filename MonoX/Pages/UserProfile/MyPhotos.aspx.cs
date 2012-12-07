using MonoSoftware.MonoX.BusinessLayer;
using MonoSoftware.MonoX.DAL.EntityClasses;
using MonoSoftware.MonoX.Repositories;
using MonoSoftware.MonoX.Resources;
using MonoSoftware.MonoX.Utilities;
using System;
using System.Collections.Generic;

namespace MonoSoftware.MonoX.Pages.Profile
{
    public partial class MyPhotos : BaseProfilePage
    {
        #region Page Events
        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e); 
            if (!String.IsNullOrEmpty(UserName) && !Guid.Empty.Equals(UserId))
            {                
                if (CurrentUser != null)
                {
                    snPhotoGallery.DefaultActiveControl = ActivePhotoGalleryControl.MyAlbumList;
                    snPhotoGallery.UserId = UserId;
                    snPhotoGallery.AvailablePrivacyLevelIds.Remove(PrivacyLevelEntity.PrivacyLevelFriends.Id);                    
                    profileHeader.UserId = UserId;
                    profileHeader.DataBind();
                }
            }
            else
            {
                this.SetPageTitle(MonoSoftware.MonoX.Resources.PageResources.UserProfile_NoSuchUser); 
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            snPhotoGallery.EnableAlbumCreation = Page.User.Identity.IsAuthenticated && snPhotoGallery.UserId.Equals(SecurityUtility.GetUserId());
            base.OnLoad(e);
        }

        protected override void OnPreRender(EventArgs e)
        {            
            if (CurrentUser != null)
            {
                this.SetPageTitle(String.Format(MonoSoftware.MonoX.Resources.PageResources.UserProfile_Title, CurrentUser.UserShortDisplayName));
            }
            base.OnPreRender(e);
        }
        #endregion

    }
}
