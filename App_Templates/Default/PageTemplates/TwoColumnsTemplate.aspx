<%@ Page
    Language="C#"
    AutoEventWireup="True"
    CodeBehind="Dashboard.aspx.cs"
    Inherits="MonoSoftware.MonoX.BasePage"
    Theme="Default"
    MasterPageFile="~/MonoX/MasterPages/Default.master" %>
        
<%@ MasterType TypeName="MonoSoftware.MonoX.BaseMasterPage" %>

<%@ Import Namespace="MonoSoftware.MonoX.Resources" %>
<%@ Register TagPrefix="MonoX" TagName="Editor" Src="~/MonoX/ModuleGallery/MonoXHtmlEditor.ascx" %>
<%@ Register Assembly="MonoX" Namespace="MonoSoftware.MonoX" TagPrefix="portal" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cp" runat="server">             
    <div class="content-wrapper two-columns">
        <div class="main-content">
            <portal:PortalWebPartZone HeaderText="Content zone" ID="contentPartZone" runat="server" Width="100%" ChromeTemplateFile="Standard.htm">
                <ZoneTemplate>
                    <MonoX:Editor ID="ctlEditor" runat="server" Title=""></MonoX:Editor>
                </ZoneTemplate>
            </portal:PortalWebPartZone>
        </div>
        <div class="side-content">
            <portal:PortalWebPartZone HeaderText="Right part zone" ID="rightPartZone" runat="server" Width="100%" ChromeTemplateFile="RightColumn.htm" ShowChromeForNonAdmins="true">
                <ZoneTemplate>
                    <MonoX:Editor runat="server" ID="editor2" />  
                </ZoneTemplate>
            </portal:PortalWebPartZone>
        </div>        
    </div>
</asp:Content>