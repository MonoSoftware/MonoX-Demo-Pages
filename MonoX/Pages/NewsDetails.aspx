<%@ Page
    Language="C#"
    AutoEventWireup="True"
    CodeBehind="NewsDetails.aspx.cs"
    Inherits="MonoSoftware.MonoX.Pages.NewsDetails"    
    MasterPageFile="~/MonoX/MasterPages/Default.master"
%>
        
<%@ MasterType TypeName="MonoSoftware.MonoX.BaseMasterPage" %>   

<%@ Import Namespace="MonoSoftware.MonoX.Resources" %>
<%@ Register TagPrefix="MonoX" TagName="News" Src="~/MonoX/ModuleGallery/News/SingleNewsModule.ascx" %>
<%@ Register Assembly="MonoX" Namespace="MonoSoftware.MonoX" TagPrefix="portal" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cp" runat="server">
    <div class="content-wrapper">
        <div class="main-content">         
            <h2><asp:Literal runat="server" ID="ltlTitle"></asp:Literal></h2>
            <portal:PortalWebPartZoneTableless HeaderText='<%$ Code: PageResources.Zone_ContentZone %>' ID="contentPartZone" runat="server" Width="100%" ChromeTemplateFile="LeftColumn.htm">
                <ZoneTemplate>
                    <MonoX:News ID="ctlNews" runat="server"></MonoX:News>
                </ZoneTemplate>
            </portal:PortalWebPartZoneTableless>
        </div>
    </div>
</asp:Content>