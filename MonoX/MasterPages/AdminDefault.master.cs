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
            base.OnInit(e);
            if (!String.IsNullOrEmpty(ApplicationSettings.jQueryReferencePath))
            {                
                JavascriptUtility.RegisterClientScriptInclude(this.Page, UrlFormatter.ResolveUrl(ApplicationSettings.jQueryReferencePath));
            }
            AjaxScriptManager.AsyncPostBackError += new EventHandler<AsyncPostBackErrorEventArgs>(AjaxScriptManager_OnAsyncPostBackError);
            AjaxScriptManager.AllowCustomErrorsRedirect = false;            
        }

        protected override void OnLoad(EventArgs e)
        {            
            ScriptManager.GetCurrent(this.Page).Scripts.Add(new ScriptReference(Paths.MonoX.Scripts.WebKitAjax_js));
            ScriptManager.GetCurrent(this.Page).Scripts.Add(new ScriptReference(Paths.MonoX.Scripts.WebFormsOverrides_js));
            ScriptManager.GetCurrent(this.Page).Scripts.Add(new ScriptReference(Paths.MonoX.Scripts.TextareaMaxLength_js));
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