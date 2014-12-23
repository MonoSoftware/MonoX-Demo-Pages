using MonoSoftware.MonoX.Utilities;
using System;

namespace MonoSoftware.MonoX.Pages.SocialNetworking
{
    public partial class FileView : BasePage
    {
        #region Page Events
        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            ctlFileView.EnableFileDelete = false;            
            ctlFileView.Mode = UrlParams.SocialNetworking.Files.Mode.HasValue ? UrlParams.SocialNetworking.Files.Mode.Value : FileViewWorkingMode.Preview;
            this.SetPageTitle(MonoSoftware.MonoX.Resources.PageResources.FileView_Title);            
        } 
        #endregion
    }
}
