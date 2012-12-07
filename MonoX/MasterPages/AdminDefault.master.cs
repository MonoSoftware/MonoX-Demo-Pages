using MonoSoftware.MonoX.Utilities;
using MonoSoftware.Web;
using System;
using System.Web.UI;
using System.Web.UI.HtmlControls;

namespace MonoSoftware.MonoX.MasterPages
{
    public partial class AdminDefault : BaseMasterPage
    {
        #region Properties
        public bool ShowAdminHeader { get; set; }

        //private HtmlGenericControl _body;
        public HtmlGenericControl Body
        {
            get { return this.body; }
        }
        #endregion

        #region Constructor
        public AdminDefault()
        {
            ShowAdminHeader = true;
        }
        #endregion

        #region Page Events
        protected override void OnInit(EventArgs e)
        {            
            if (!String.IsNullOrEmpty(ApplicationSettings.jQueryReferencePath))
            {
                //JavascriptUtility.RegisterClientScriptInclude(this, this.GetType(), ApplicationSettings.jQueryReferencePath, UrlFormatter.ResolveUrl(ApplicationSettings.jQueryReferencePath));
                JavascriptUtility.RegisterClientScriptInclude(this.Page, UrlFormatter.ResolveUrl(ApplicationSettings.jQueryReferencePath));
            }
            AjaxScriptManager.AsyncPostBackError += new EventHandler<AsyncPostBackErrorEventArgs>(AjaxScriptManager_OnAsyncPostBackError);
            AjaxScriptManager.AllowCustomErrorsRedirect = false;
            base.OnInit(e);
        }

        protected override void OnLoad(EventArgs e)
        {            
            ScriptManager.GetCurrent(this.Page).Scripts.Add(new ScriptReference(Paths.MonoX.Scripts.WebKitAjax_js));
            //add the compatibility scripts for the IE6
            if (Request.GetBrowserSettings().SubType.Equals(BrowserType.IE6))
            {
                ScriptManager.GetCurrent(this.Page).Scripts.Add(new ScriptReference(Paths.MonoX.Scripts.IE6.ie7_standard_p_js));
            }
            base.OnLoad(e);
        }

        protected override void OnPreRender(EventArgs e)
        {
            adminHeader.Visible = ShowAdminHeader; 
            base.OnPreRender(e);
        }
        #endregion

        #region Methods
        protected void AjaxScriptManager_OnAsyncPostBackError(object sender, AsyncPostBackErrorEventArgs e)
        {
            AjaxScriptManager.AsyncPostBackErrorMessage = e.Exception.ToString();
        }
        #endregion
    }
}