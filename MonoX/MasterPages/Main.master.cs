using MonoSoftware.MonoX.Utilities;
using MonoSoftware.Web;
using System;
using System.Web.UI;
using System.Security;
using System.Web.Security;
using MonoSoftware.Core;

namespace MonoSoftware.MonoX.MasterPages
{
    public partial class Main : BaseMasterPage
    {
        #region Page Events
        protected override void OnInit(EventArgs e)
        {            
            //DO NOT change the ID of the master page - it conflicts with several of the 3rd party controls, including RadComboBox (LoadOnDemand scenario)
            //this.ID = "mp1";
            //NOTE: modified MicrosoftAjax.js is used to achieve compatibility with Google Chrome - and WebKit-based browsers like Safari - via ScriptReference to ~/MonoX/scripts/WebKitAjax.js in ascx file
            //http://forums.asp.net/p/1252014/2431554.aspx
            if (!String.IsNullOrEmpty(ApplicationSettings.jQueryReferencePath))
            {
                //JavascriptUtility.RegisterClientScriptInclude(this.Page, this.Page.GetType(), ApplicationSettings.jQueryReferencePath, UrlFormatter.ResolveUrl(ApplicationSettings.jQueryReferencePath));
                JavascriptUtility.RegisterClientScriptInclude(this.Page, UrlFormatter.ResolveUrl(ApplicationSettings.jQueryReferencePath));
            }
            if (SecurityUtility.AllowPersonalization())
            {
                PageUtility.InjectJQueryUIHeaders(this.Page);
            }            
            AjaxScriptManager.AsyncPostBackError += new EventHandler<AsyncPostBackErrorEventArgs>(AjaxScriptManager_OnAsyncPostBackError);
            AjaxScriptManager.AllowCustomErrorsRedirect = false;
            base.OnInit(e);
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
            //modify root HTML tag if neccessary
            if (!string.IsNullOrEmpty(HtmlTagCustomAttributes))
            {
                ltlRootHtml.Visible = true;
                ltlRootHtml.Text = HtmlTagCustomAttributes;
            }
            else
                ltlRootHtml.Visible = false;
            if (string.IsNullOrEmpty(ApplicationSettings.Doctype))
            {
                ltlDoctype.Text = "<!DOCTYPE html PUBLIC \" -//W3C//DTD XHTML 1.0 Transitional//EN\" \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd\">";
                ltlXmlns.Text = " xmlns=\"http://www.w3.org/1999/xhtml\" ";
            }
            else
            {
                ltlDoctype.Text = ApplicationSettings.Doctype;
                if (ApplicationSettings.Doctype.ToLower().Contains("XHTML"))
                    ltlXmlns.Text = " xmlns=\"http://www.w3.org/1999/xhtml\" ";
            }

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