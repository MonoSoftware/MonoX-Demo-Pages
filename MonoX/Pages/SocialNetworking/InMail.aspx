<%@ Page Title="" 
    Language="C#"
    MasterPageFile="~/MonoX/MasterPages/Default.master"
    AutoEventWireup="true"
    CodeBehind="InMail.aspx.cs"
    Inherits="MonoSoftware.MonoX.Pages.SocialNetworking.InMail" %>
    
<%@ MasterType TypeName="MonoSoftware.MonoX.BaseMasterPage" %>   
<%@ Import Namespace="MonoSoftware.MonoX.Resources" %>
<%@ Register TagPrefix="MonoX" TagName="MessageCenter" Src="~/MonoX/ModuleGallery/SocialNetworking/InMailMessaging/MessageCenter.ascx" %>
<%@ Register Assembly="MonoX" Namespace="MonoSoftware.MonoX" TagPrefix="portal" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cp" runat="server">
<div class="content-wrapper">
    <div class="messages main-content">
    <portal:PortalWebPartZoneTableless HeaderText='<%$ Code: PageResources.Zone_LeftPartZone %>' ID="leftPartZone" runat="server" Width="100%" ChromeTemplateFile="LeftColumn.htm">
        <ZoneTemplate>
            <MonoX:MessageCenter runat="server" ID="messageList" UsePrettyPhoto="true" />
        </ZoneTemplate>
    </portal:PortalWebPartZoneTableless>
    </div>
</div>
</asp:Content>
