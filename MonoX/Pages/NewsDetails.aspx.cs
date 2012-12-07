using System;
using MonoSoftware.MonoX.Resources;

namespace MonoSoftware.MonoX.Pages
{
    public partial class NewsDetails : BasePage
    {
        #region Page Events
        protected override void OnLoad(EventArgs e)
        {
            ctlNews.ReadMorePageTitle = PageResources.News_ReadMore_Title;
            base.OnLoad(e);
        }
        #endregion

    }
}
