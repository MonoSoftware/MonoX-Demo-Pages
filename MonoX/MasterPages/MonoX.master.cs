using MonoSoftware.MonoX.Resources;
using MonoSoftware.MonoX.Utilities;
using MonoSoftware.Web;
using System;
using System.Globalization;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls.WebParts;
using System.Collections.Generic;
using Telerik.Web.UI;
using MonoSoftware.MonoX.Controls;

namespace MonoSoftware.MonoX.MasterPages
{
    public partial class MonoX : BaseMasterPage, IToolboxMasterPage
    {
        WebPartManager _wpm;

        #region Properties
        private bool _isLayoutDoneWithTable = true;

        /// <summary>
        /// Get or set if web site layout is designed via table-based design.
        /// Note: Set this to false if your layout is using tableless design (DIV-based approach).
        /// </summary>
        public bool IsLayoutDoneWithTable
        {
            get { return _isLayoutDoneWithTable; }
            set { _isLayoutDoneWithTable = value; }
        }

        public string toolboxContentStyle = string.Empty;

        #endregion

        #region Page Events

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            _wpm = WebPartManager.GetCurrentWebPartManager(this.Page);
            if (this.Page is BasePage)
                ((BasePage)this.Page).ToolboxPanel = pnlToolboxMain;
            ltlInfo.Text = String.Format("MonoX v{0} [{1}], DB v{2}", MonoSoftware.MonoX.Utilities.MonoXUtility.AssemblyVersion, MonoSoftware.MonoX.Utilities.MonoXUtility.AssemblyDate.ToString(CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern), MonoSoftware.MonoX.Utilities.MonoXUtility.DBVersion);
            SetRefreshCacheUrl();
            CheckCacheRefresh();            
        }

        private void SetRefreshCacheUrl()
        {
            UrlBuilder builder = new UrlBuilder(HttpRequestExtension.GetAbsoluteRawUri());
            if (!builder.QueryString.ContainsKey(MonoSoftware.MonoX.UrlParams.Reload.Name))
                builder.QueryString.Add(MonoSoftware.MonoX.UrlParams.Reload.Name, "true");
            lnkRefreshCache.NavigateUrl = builder.ToString();
        }

        private void CheckCacheRefresh()
        {
            if (UrlParams.Reload.HasValue)
            {
                HttpResponse.RemoveOutputCacheItem(this.Request.Url.AbsolutePath);
                UrlBuilder builder = new UrlBuilder(HttpRequestExtension.GetAbsoluteRawUri());
                builder.QueryString.Remove(MonoSoftware.MonoX.UrlParams.Reload.Name);
                builder.Navigate();
            }
        }

        private void LocalizeControls()
        {
            pnlToggle.GroupingText = DefaultResources.MonoXMaster_PnlToggle_GroupingText;
            pnlToggle.ToolTip = DefaultResources.MonoXMaster_PnlToggle_ToolTip;
            ltlClickHere.Text = DefaultResources.MonoXMaster_LtlClickHere_Text;
            ltlPortalAdmin.Text = DefaultResources.MonoXMaster_LtlPortalAdmin_Text;
            loginNameShort.FormatString = DefaultResources.MonoXMaster_LoginNameShort_FormatString;
            loginStatusShort.LogoutText = DefaultResources.MonoXMaster_LoginStatusShort_LogoutText;
            imgToggle.AlternateText = DefaultResources.MonoXMaster_ImgToggle_AlternateText;
            imgToggle.ToolTip = DefaultResources.MonoXMaster_ImgToggle_ToolTip;
            imgHelp.ToolTip = DefaultResources.MonoXMaster_ImgHelp_ToolTip;
            pnlToolboxMain.GroupingText = DefaultResources.MonoXMaster_PnlToolboxMain_GroupingText;
            pnlToolboxMain.ToolTip = DefaultResources.MonoXMaster_PnlToolboxMain_ToolTip;
            tabPageTasksPane.Text = DefaultResources.MonoXMaster_PageTasksPane_Text;
            tabEditorPane.Text = DefaultResources.MonoXMaster_EditorPane_Text;
            tabCatalogPane.Text = DefaultResources.MonoXMaster_CatalogPane_Text;
            tabConnectionsPane.Text = DefaultResources.MonoXMaster_ConnectionsPane_Text;
            tabControlsPane.Text = DefaultResources.MonoXMaster_ControlsPane_Text;
            ltlControlsHeader.Text = DefaultResources.MonoXMaster_ControlsPaneHeader_Text;

            editorZone.ApplyVerb.Description = DefaultResources.MonoXMaster_EditorZone_ApplyVerb_Description;
            editorZone.ApplyVerb.Text = DefaultResources.MonoXMaster_EditorZone_ApplyVerb_Text;
            editorZone.CancelVerb.Description = DefaultResources.MonoXMaster_EditorZone_CancelVerb_Description;
            editorZone.CancelVerb.Text = DefaultResources.MonoXMaster_EditorZone_CancelVerb_Text;
            editorZone.EmptyZoneText = DefaultResources.MonoXMaster_EditorZone_EmptyZoneText;
            editorZone.HeaderText = DefaultResources.MonoXMaster_EditorZone_HeaderText;
            editorZone.InstructionText = DefaultResources.MonoXMaster_EditorZone_InstructionText;
            editorZone.OKVerb.Description = DefaultResources.MonoXMaster_EditorZone_OKVerb_Description;
            editorZone.OKVerb.Text = DefaultResources.MonoXMaster_EditorZone_OKVerb_Text;

            if (propertyGridEditorPart != null)
                propertyGridEditorPart.Title = DefaultResources.MonoXMaster_PropertyGridEditorPart_Title;
            if (appearanceEditorPart != null)
                appearanceEditorPart.Title = DefaultResources.MonoXMaster_AppearanceEditorPart_Title;
            if (layoutEditorPart != null)
                layoutEditorPart.Title = DefaultResources.MonoXMaster_LayoutEditorPart_Title;
            if (behaviorEditorPart != null)
                behaviorEditorPart.Title = DefaultResources.MonoXMaster_BehaviorEditorPart_Title;

            catalogZone.EmptyZoneText = DefaultResources.MonoXMaster_CatalogZone_EmptyZoneText;
            catalogZone.HeaderText = DefaultResources.MonoXMaster_CatalogZone_HeaderText;
            catalogZone.InstructionText = DefaultResources.MonoXMaster_CatalogZone_InstructionText;
            catalogZone.SelectTargetZoneText = DefaultResources.MonoXMaster_CatalogZone_SelectTargetZoneText;

            connectionsZone.ConfigureConnectionTitle = DefaultResources.MonoXMaster_ConnectionsZone_ConfigureConnectionTitle;
            connectionsZone.ConnectToConsumerInstructionText = DefaultResources.MonoXMaster_ConnectionsZone_ConnectToConsumerInstructionText;
            connectionsZone.ConnectToConsumerText = DefaultResources.MonoXMaster_ConnectionsZone_ConnectToConsumerText;
            connectionsZone.ConnectToConsumerTitle = DefaultResources.MonoXMaster_ConnectionsZone_ConnectToConsumerTitle;
            connectionsZone.ConnectToProviderInstructionText = DefaultResources.MonoXMaster_ConnectionsZone_ConnectToProviderInstructionText;
            connectionsZone.ConnectToProviderText = DefaultResources.MonoXMaster_ConnectionsZone_ConnectToProviderText;
            connectionsZone.ConnectToProviderTitle = DefaultResources.MonoXMaster_ConnectionsZone_ConnectToProviderTitle;
            connectionsZone.ConsumersInstructionText = DefaultResources.MonoXMaster_ConnectionsZone_ConsumersInstructionText;
            connectionsZone.ConsumersTitle = DefaultResources.MonoXMaster_ConnectionsZone_ConsumersTitle;
            connectionsZone.ExistingConnectionErrorMessage = DefaultResources.MonoXMaster_ConnectionsZone_ExistingConnectionErrorMessage;
            connectionsZone.GetFromText = DefaultResources.MonoXMaster_ConnectionsZone_GetFromText;
            connectionsZone.GetText = DefaultResources.MonoXMaster_ConnectionsZone_GetText;
            connectionsZone.HeaderText = DefaultResources.MonoXMaster_ConnectionsZone_HeaderText;
            connectionsZone.InstructionText = DefaultResources.MonoXMaster_ConnectionsZone_InstructionText;
            connectionsZone.InstructionTitle = DefaultResources.MonoXMaster_ConnectionsZone_InstructionTitle;
            connectionsZone.NewConnectionErrorMessage = DefaultResources.MonoXMaster_ConnectionsZone_NewConnectionErrorMessage;
            connectionsZone.NoExistingConnectionInstructionText = DefaultResources.MonoXMaster_ConnectionsZone_NoExistingConnectionInstructionText;
            connectionsZone.NoExistingConnectionTitle = DefaultResources.MonoXMaster_ConnectionsZone_NoExistingConnectionTitle;
            connectionsZone.ProvidersInstructionText = DefaultResources.MonoXMaster_ConnectionsZone_ProvidersInstructionText;
            connectionsZone.ProvidersTitle = DefaultResources.MonoXMaster_ConnectionsZone_ProvidersTitle;
            connectionsZone.SendText = DefaultResources.MonoXMaster_ConnectionsZone_SendText;
            connectionsZone.SendToText = DefaultResources.MonoXMaster_ConnectionsZone_SendToText;
            lblConnectionsDescription.Text = DefaultResources.MonoXMaster_ConnectionsZone_GeneralInstructionsText;
        }

        protected override void OnLoad(EventArgs e)
        {            
            LocalizeControls();
            lnkAdminDefault.DataBind();
            lnkAdminDefault.Visible = PageUtility.CanViewAdminPage(Paths.MonoX.Admin.Default_aspx);
            ltlSeparator.Visible = lnkAdminDefault.Visible;

            ClientScriptManager cs = this.Page.ClientScript;
            if (!cs.IsClientScriptIncludeRegistered(this.GetType(), Paths.App_Themes.All.Common.Common_css))
            {
                //the css below is needed to hide the web part padding and headers
                HtmlFormatter.CreateCssLink(this.Page, this.ResolveUrl(Paths.App_Themes.All.Common.Common_css));

                if (SecurityUtility.AllowPersonalization())
                {
                    HtmlFormatter.CreateCssLink(this.Page, this.ResolveUrl(Paths.App_Themes.All.Common.Slider_css));
                }

            }

            if (SecurityUtility.AllowPersonalization())
            {
                bool isBrowserIe = Request.GetBrowserSettings().Type.Equals(BrowserType.IE);
                if (!IsPostBack && !ScriptManager.GetCurrent(this.Page).IsInAsyncPostBack)
                {
                    if (isBrowserIe)
                    {
                        toolboxContentStyle = "visibility:hidden;display:none;";
                    }
                    else
                    {
                        toolboxContentStyle = "visibility:hidden;display:none;height:0;";
                    }
                    
                    if (!Page.ClientScript.IsStartupScriptRegistered("ToolBoxUnHideOnLoad"))
                    {
                        string leftNavigatorContent = "setTimeout('ToolBoxUnHideOnLoad()', 100); ";
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "ToolBoxUnHideOnLoad", leftNavigatorContent, true);
                    }

                }
                string script = @"
            <script type=""text/javascript"" language=""javascript"">
            //<![CDATA[
            function SplitterLoaded(obj, args)
            {   
                document.getElementById('tblPageTasks').style.width = screen.width - 40;
            }

            function ToggleEditorDisplay(divClientID, imgClientUrl, expandImageUrl, minimizeImageUrl) {

                var el = document.getElementById(divClientID) ;
                if( el.style.display=='none' ) {
                    el.style.display='';
                    document.images[imgClientUrl].src= minimizeImageUrl;
                } else {
                    el.style.display='none';
                    document.images[imgClientUrl].src= expandImageUrl;
                }
            }
            
            //]]>
            </script>
            ";
                if (!cs.IsClientScriptBlockRegistered(this.GetType(), "PageTasksScript"))
                {
                    cs.RegisterClientScriptBlock(this.GetType(), "PageTasksScript", script);
                }


            }

            this.editorZone.HeaderCloseVerb.Visible = false;
            this.catalogZone.HeaderCloseVerb.Visible = false;

            toolbox_content.Attributes.Add("style", toolboxContentStyle);
            string tblTopMouseUp = !IsLayoutDoneWithTable ? string.Format("javascript: document.getElementById('{0}').style.overflow = 'visible';", pnlToolboxMain.ClientID) : string.Empty;
            tblTop.Attributes.Add("onmouseup", tblTopMouseUp);

            //we need to set up the window manager in order to get the source editor popup working in the admin mode
            if (SecurityUtility.IsAdmin())
            {
                if (Page != null && Page.Form != null && Page.Form.FindControl("editorSourceWindowManager") == null)
                {
                    MonoXWindowManager radWindowManager = new MonoXWindowManager();
                    radWindowManager.ReloadOnShow = true;
                    radWindowManager.ID = "editorSourceWindowManager";
                    radWindowManager.OnClientClose = "EditSourceRefreshParentPage";
                    radWindowManager.Skin = "MetroTouch";
                    this.Page.Form.Controls.Add(radWindowManager);
                }

                //prepares the popup script
                string windowScript = @"function OpenRadWindow(url) {
                    var oWindow = window.radopen(url, 'editSourceWindow');
                    oWindow.set_modal(true);
                    oWindow.SetSize(900, 500);
                    oWindow.Center();
                }

                function EditSourceRefreshParentPage()
                {
                    document.location.reload();
                }

                ";
                JavascriptUtility.RegisterStartupScript(this.Page, this.Page.GetType(), "editorWindowScriptInit", windowScript, true);

            }
            
            base.OnLoad(e);
        }


        private void RegisterHideOnLoadScript()
        {
            ClientScriptManager cs = this.Page.ClientScript;
            string isLayoutDone = !IsLayoutDoneWithTable ? string.Format("if (document.getElementById('{0}')) {{ document.getElementById('{0}').style.display = ''; }}", pnlToolboxMain.ClientID) : string.Empty;

            string hideOnLoadScript = @"
        <script type='text/javascript' >
                //<![CDATA[ 
                    " +
                        isLayoutDone +
                        @"
                    //Note: This is a hack for ajaxToolkit:CollapsiblePanelExtender lack of functionality (HideOnLoad)    
                    function ToolBoxUnHideOnLoad()
                    {
                        var ToolBoxHideOnLoadTargetControlID = document.getElementById('" + toolbox_content.ClientID + @"');
                        if (ToolBoxHideOnLoadTargetControlID)
                        {
                            if (ToolBoxHideOnLoadTargetControlID.style.height)
                                ToolBoxHideOnLoadTargetControlID.style.height = '100%';
                            if (ToolBoxHideOnLoadTargetControlID.style.visibility)
                                ToolBoxHideOnLoadTargetControlID.style.visibility = 'visible';
                            if (ToolBoxHideOnLoadTargetControlID.style.display)
                                ToolBoxHideOnLoadTargetControlID.style.display = 'block';
                        }
                    }            
                    
                //]]>
        </script>          
        ";
            if (!cs.IsClientScriptBlockRegistered(this.GetType(), "HideOnLoadScript"))
            {
                cs.RegisterClientScriptBlock(this.GetType(), "HideOnLoadScript", hideOnLoadScript);
            }

        }

        protected override void OnPreRender(EventArgs e)
        {
            //if ApplicationSettings.AllowCloseVerb is set to true, add PageCatalogPart to the front end so it could be administered
            ltlCache.Visible = this.CacheDuration > 0;
            lnkRefreshCache.Visible = this.CacheDuration > 0;
            
            if (this.CacheDuration > 0)
            {
                ltlCache.Text = string.Format(DefaultResources.CachedOnFormatText, DateTime.Now.ToString());
                lnkRefreshCache.Text = DefaultResources.Refresh;
            }

            bool adminToolbarVisible = true;
            if (this.Page is BasePage)
                adminToolbarVisible = ((BasePage)this.Page).AdminToolbarVisible;

            if (SecurityUtility.AllowPersonalization() && adminToolbarVisible)
            {
                pnlToggle.Visible = true;
                cpeToolbox.Enabled = true;
                pnlToolboxMain.Visible = true;
                ToggleEditorZone();
            }
            else
            {
                pnlToggle.Visible = false;
                cpeToolbox.Enabled = false;
                pnlToolboxMain.Visible = false;
            }

            if (SecurityUtility.AllowPersonalization() || adminToolbarVisible)
            {
                RegisterHideOnLoadScript();
            }
            
            if (!SecurityUtility.AllowPersonalization())
            {
                //hide warning texts and scripts that are rendered directly to the page to SEO optimize the page      
                wpm.DeleteWarning = string.Empty;
                wpm.ExportSensitiveDataWarning = string.Empty;
                wpm.CloseProviderWarning = string.Empty;
                wpm.EnableClientScript = false;
            }


            pnlToolboxMain.CssClass = "topPanel";
            if (!IsLayoutDoneWithTable)
            {
                pnlToggle.CssClass = "AdminHeaderHolder";
                pnlToolboxMain.CssClass = "topHolderPanel";
            }
            base.OnPreRender(e);
        }

        protected void PortalWebPartManager_Init(object sender, EventArgs e)
        {
            if (this.Page is BasePage)
            {
                ((BasePage)this.Page).OnInitWebPartManager(sender, e);
            }
        }

        #endregion

        #region Methods
        private void ToggleEditorZone()
        {
            WebPartDisplayMode mode = _wpm.DisplayMode;
            if (SecurityUtility.AllowPersonalization())
            {
                pnlToolboxMain.Visible = true;
                tabAdminStrip.Tabs[0].Visible = true;
                PageTasksPaneView.Visible = true;
                
                if (Request.Params["__EVENTARGUMENT"] != null && Request.Params["__EVENTARGUMENT"].ToLower().StartsWith("delete:wp"))
                {
                    tabAdminStrip.Tabs[1].Visible = false;
                    EditorPaneView.Visible = false;
                }
                else
                {
                    tabAdminStrip.Tabs[1].Visible = (mode == WebPartManager.EditDisplayMode);
                    EditorPaneView.Visible = (mode == WebPartManager.EditDisplayMode);
                    //open the properties window if needed
                    if (Request.Params["__EVENTARGUMENT"] != null && Request.Params["__EVENTARGUMENT"].ToLower().Contains(":editverb:"))
                    {
                        tabAdminStrip.SelectedIndex = 1;
                        cpeToolbox.Collapsed = false;
                        cpeToolbox.ClientState = false.ToString().ToLower();
                    }
                }
                tabAdminStrip.Tabs[2].Visible = (mode == WebPartManager.CatalogDisplayMode);
                CatalogPaneView.Visible = (mode == WebPartManager.CatalogDisplayMode);
                tabAdminStrip.Tabs[3].Visible = (mode == WebPartManager.ConnectDisplayMode);
                ConnectionsPaneView.Visible = (mode == WebPartManager.ConnectDisplayMode);
                if (CatalogPaneView.Visible)
                {
                    tabAdminStrip.SelectedIndex = 2;
                }
                else if (ConnectionsPaneView.Visible)
                {
                    tabAdminStrip.SelectedIndex = 3;
                }
                else if (!tabAdminStrip.Tabs[tabAdminStrip.SelectedIndex].Visible)
                {
                    tabAdminStrip.SelectedIndex = 0;
                }
                adminMultiPage.SelectedIndex = tabAdminStrip.SelectedIndex;

                //displays the edit source tab if appropriate.
                tabAdminStrip.Tabs[4].Visible = (mode == WebPartManager.DesignDisplayMode);
                if (mode == WebPartManager.DesignDisplayMode)
                {
                    List<ControlData> ucs = new List<ControlData>();
                    ucs.Add(new ControlData(GetControlName(this.Page.AppRelativeVirtualPath), BasePart.BuildEditSourceUrl(this.Page.AppRelativeVirtualPath, this.Page, true)));
                    ParseControlTree(Page, ucs);
                    rptControls.DataSource = ucs;
                    rptControls.DataBind();
                }
            }
        }

        /// <summary>
        /// Retrieves the name of the control from its path.
        /// </summary>
        /// <param name="fullPath">Full control path.</param>
        /// <returns>Control name.</returns>
        private string GetControlName(string fullPath)
        {

            string toReturn = string.Empty;
            string[] parts = fullPath.Split('/');
            if (parts.Length > 0)
                toReturn = parts[parts.Length - 1];
            return toReturn;
        }

        /// <summary>
        /// Recursively parses the control tree on the page.
        /// </summary>
        /// <param name="control">Control from which to start.</param>
        /// <param name="colControls">Collection of parsed controls.</param>
        /// <returns>A parsed control.</returns>
        private Control ParseControlTree(Control control, List<ControlData> colControls)
        {
            Control returnControl = null;
            

            if (control != null)
            {
                foreach (Control c in control.Controls)
                {
                    if (c is UserControl)
                    {
                        UserControl uc = c as UserControl;
                        string path = uc.AppRelativeVirtualPath;
                        string url = BasePart.BuildEditSourceUrl(path, this.Page, true);

                        if (colControls.Find(x => (x.Url == url)) == null)
                        {
                            colControls.Add(new ControlData(GetControlName(path), url));

                        }
                    }
 
                    if (c.HasControls())
                    {
                        returnControl = ParseControlTree(c, colControls);
                        if (returnControl != null) break;
                    }

                }
            }
            return returnControl;
        }

        
        /// <summary>
        /// Class used to bind the control data to the list of controls in the parsed tree.
        /// </summary>
        protected class ControlData
        {
            public string Name { get; set; }
            public string Url { get; set; }
            public ControlData(string name, string url)
            {
                Name = name;
                Url = url;
            }
        }


        #endregion


        #region IToolboxMasterPage Members

        public TemplatedEditorZone EditorZone
        {
            get { return editorZone; }
        }

        public PortalCatalogZone CatalogZone
        {
            get { return catalogZone; }
        }

        #endregion


    }
}