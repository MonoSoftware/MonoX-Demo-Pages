using System;
using MonoSoftware.MonoX.Repositories;
using MonoSoftware.Web;
using MonoSoftware.Core;
using MonoSoftware.MonoX.Resources;
using MonoSoftware.MonoX.Utilities;
using MonoSoftware.MonoX.BusinessLayer;

namespace MonoSoftware.MonoX.Pages
{
    public partial class PageRemoval : BasePage
    {
        #region Fields
        /// <summary>
        /// Page path removal query string parameter.
        /// </summary>
        public const string PagePathToRemoveParam = "pptr";

        /// <summary>
        /// Page path removal strongly typed query string.
        /// </summary>
        public static UrlParam<string> PagePathToRemove = new UrlParam<string>(PagePathToRemoveParam);
        #endregion

        #region Properties
        private string _redirectUrl = null;
        /// <summary>
        /// Gets or sets the redirect url when personalization is removed or cancel is pressed.
        /// </summary>
        public string RedirectUrl
        {
            get
            {
                if (String.IsNullOrEmpty(_redirectUrl))
                {
                    if (UrlParams.ReturnUrl.HasValue)
                        _redirectUrl = UrlParams.ReturnUrl.Value;
                }
                return _redirectUrl;
            }
            set
            {
                _redirectUrl = value;
            }
        }
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor.
        /// </summary>
        public PageRemoval()
            : base()
        {            
        }
        #endregion

        #region Page Events
        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            btnYes.Click += new EventHandler(btnYes_Click);
            btnNo.Click += new EventHandler(btnNo_Click);                        
        }

        protected override void OnLoad(EventArgs e)
        {
            panSuccess.Visible = false;
            base.OnLoad(e);
        }

        protected override void OnPreRender(EventArgs e)
        {
            panWarning.Visible = false;                        
            if (PagePathToRemove.HasValue)
            {
                VersionedPersonalizationProvider provider = (VersionedPersonalizationProvider)System.Web.UI.WebControls.WebParts.PersonalizationAdministration.Provider;
                panWarning.Visible = DependencyInjectionFactory.Resolve<IPageBLL>().PagePathExists(provider.GeneratePersonalizationUrl(PagePathToRemove.Value));
            }
            panNotFound.Visible = !panWarning.Visible && !panSuccess.Visible;
            if (!SecurityUtility.IsAdmin())
                OnRedirect(new EventArgs<string>(PagePathToRemove.HasValue ? PagePathToRemove.Value : Paths.Default_aspx));
            base.OnPreRender(e);
        }
        #endregion

        #region Methods
        /// <summary>
        /// Performs the page personalization removal along with page data.
        /// </summary>
        /// <param name="e">Event arguments holding the page path</param>
        protected virtual void OnPersonalizationRemoval(EventArgs<string> e)
        {
            DependencyInjectionFactory.Resolve<IPageBLL>().EnsurePagePersonalizationRemoval(e.Value);
        }

        /// <summary>
        /// Performs the page redirect.
        /// </summary>
        /// <param name="e">Event arguments holding the redirect url</param>
        protected virtual void OnRedirect(EventArgs<string> e)
        {
            if (!String.IsNullOrEmpty(e.Value))
                Response.Redirect(e.Value);
        }
        #endregion

        #region UI Events
        void btnNo_Click(object sender, EventArgs e)
        {
            string redirect = RedirectUrl;
            if (String.IsNullOrEmpty(redirect))
                redirect = Paths.Default_aspx;
            OnRedirect(new EventArgs<string>(redirect));
        }

        void btnYes_Click(object sender, EventArgs e)
        {
            if (PagePathToRemove.HasValue)
            {
                OnPersonalizationRemoval(new EventArgs<string>(PagePathToRemove.Value));
                OnRedirect(new EventArgs<string>(RedirectUrl));
                panSuccess.Visible = true;
            }
        } 
        #endregion
    }
}
