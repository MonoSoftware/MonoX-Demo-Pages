using MonoSoftware.MonoX.Resources;
using MonoSoftware.MonoX.Utilities;
using System;
using MonoSoftware.MonoX.DAL.EntityClasses;

namespace MonoSoftware.MonoX.Pages.SocialNetworking
{
    public partial class PhotoGallery : BasePage
    {

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            this.SetPageTitle(PageResources.PhotoGallery_Title);
            snPhotoGallery.Title = PageResources.Module_PhotoGallery;
            snPhotoGallery.DefaultActiveControl = ActivePhotoGalleryControl.AlbumList;
            snPhotoGalleryNewAlbums.Title = PageResources.Module_PhotoGallery;
            snPhotoGalleryNewAlbums.UserId = SecurityUtility.GetUserId();
            snPhotoGallery.AvailablePrivacyLevelIds.Remove(PrivacyLevelEntity.PrivacyLevelFriends.Id);            
        }
    }
}
