using System;
using System.Security;
using System.Web;
using System.Web.UI;
using System.Web.Configuration;
using MonoSoftware.MonoX.Resources;
using MonoSoftware.Core;
using MonoSoftware.Web;
using MonoSoftware.MonoX.Utilities;
using System.Net;
using System.Text;

namespace MonoSoftware.MonoX.Pages
{
    /// <summary>
    /// Error message output page.
    /// </summary>
    public partial class Error : BasePage
    {
        #region Constructor
        /// <summary>
        /// Constructor.
        /// </summary>
        public Error()
        {
            this.EnablePageOptimization = false;
        } 
        #endregion

        #region Properties
        private Exception _exception;
        /// <summary>
        /// Exception (Exception)
        /// </summary>
        public Exception Exception
        {
            get
            {
                if (_exception == null)
                {
                    _exception = Server.GetLastError();
                }
                return _exception;
            }
        }

        /// <summary>
        /// Gets or sets the error message title.
        /// </summary>
        public new string Title
        {
            get { return ViewState["Title"] as string; }
            set { ViewState["Title"] = value; }
        }


        /// <summary>
        /// Gets or sets error message description.
        /// </summary>
        public string Description
        {
            get { return ViewState["Description"] as string; }
            set { ViewState["Description"] = value; }
        } 
        #endregion

        #region Page Events
        protected override void OnLoad(EventArgs e)
        {
            string errorPagePath = Request.Url.PathAndQuery;
            try
            {
                if (HttpContext.Current.IsCustomErrorEnabled)
                {
                    errorPagePath = PageUtility.GetCustomErrorsDefaultRedirectUrl(HttpContext.Current);
                }
            }
            catch (Exception ex)
            {
                log.Error(ex);
            }
            this.Response.SetFormActionUrl(ResolveUrl(errorPagePath));

            lnkHome.Text = ErrorMessages.ToContinueWorkingWithApplicationClickHere;
            Title = ErrorMessages.UnhandledError;
            Description = ErrorMessages.UnhandledErrorLongMessage;
            if (!IsPostBack && Exception != null)
            {
                if (Exception is SecurityException || HasSecurityException(Exception))
                {
                    Title = ErrorMessages.Authorization_Title;
                    Description = ErrorMessages.Authorization_Description;
                }
                else if (Exception is UserException)
                {
                    if (ApplicationSettings.ShowDetailedErrorsForNonAdmin || (!ApplicationSettings.ShowDetailedErrorsForNonAdmin && SecurityUtility.IsAdmin()))
                        Title = ((UserException)Exception).Title;
                }
                else if (Exception is HttpException)
                {
                    if (((HttpException)Exception).GetHttpCode().Equals((int)HttpStatusCode.NotFound))
                    {
                        Response.StatusCode = (int)HttpStatusCode.NotFound;
                        Title = ErrorMessages.PageNotFound;

                        if (!ApplicationSettings.ShowDetailedErrorsForNonAdmin && !SecurityUtility.IsAdmin())
                            Description = ErrorMessages.PageNotFoundDescription;
                    }
                }
                else
                {
                    Title = ErrorMessages.Unexpected_Title;                                            
                }

                if (ApplicationSettings.ShowDetailedErrorsForNonAdmin || (!ApplicationSettings.ShowDetailedErrorsForNonAdmin && SecurityUtility.IsAdmin()))
                {
                    Description += "<br /><br />";
                    Description += Exception.GetDetailedErrorMessage("<br />");                    
                }
            }
            base.OnLoad(e);
        }
        #endregion

        #region Methods


        protected override bool AllowAccess()
        {
            //allow access to all users, otherwise we would end up in closed loop since they are redirected here if they are not allowed to log in on some page
            return true;
        }

        protected override void OnError(EventArgs e)
        {
            //to avoid stack overflow when calling a message
            //base.OnError(e);
        }
        #endregion
    }
}
