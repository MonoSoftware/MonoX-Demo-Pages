using MonoSoftware.MonoX.Utilities;
using System;

namespace MonoSoftware.MonoX.Pages.SocialNetworking
{
    public partial class FileView : BasePage
    {
        #region Page Events
        protected override void OnInit(EventArgs e)
        {
            ctlFileView.EnableFileDelete = false;            
            ctlFileView.Mode = UrlParams.SocialNetworking.Files.Mode.HasValue ? UrlParams.SocialNetworking.Files.Mode.Value : FileViewWorkingMode.Preview;
            this.SetPageTitle(MonoSoftware.MonoX.Resources.PageResources.FileView_Title);
            base.OnInit(e);
        } 
        #endregion
    }
}
