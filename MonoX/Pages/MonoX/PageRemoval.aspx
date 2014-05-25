<%@ Page Title="" Language="C#" MasterPageFile="~/MonoX/MasterPages/Default.master"
    AutoEventWireup="true" CodeBehind="PageRemoval.aspx.cs" Inherits="MonoSoftware.MonoX.Pages.PageRemoval"
    %>

<%@ MasterType TypeName="MonoSoftware.MonoX.BaseMasterPage" %>
<%@ Import Namespace="MonoSoftware.MonoX.Resources" %>
<%@ Register Assembly="MonoX" Namespace="MonoSoftware.MonoX" TagPrefix="portal" %>
<asp:Content ID="Content2" ContentPlaceHolderID="cp" runat="Server">
    <div class="main">
        <!-- Main Start -->        
        <dl class="error-message-page content-wrapper">
            <asp:PlaceHolder ID="panSuccess" runat="server">
                <dd>
                    <img src="<%= ResolveUrl(MonoSoftware.MonoX.Paths.App_Themes.All.Common.img.check_icon_png) %>" alt="Success" />
                    <h2><%= AdminResources.PageManagerPartAdmin_DeleteSuccess%></h2>                        
                </dd>
            </asp:PlaceHolder>
            <asp:PlaceHolder ID="panNotFound" runat="server">
                <dd>
                    <img src="<%= ResolveUrl(MonoSoftware.MonoX.Paths.App_Themes.img.Error_png) %>" alt="Warning" />
                    <h2><%= ErrorMessages.PageNotFound %></h2>
                </dd>
            </asp:PlaceHolder>
            <asp:PlaceHolder ID="panWarning" runat="server">
                <dd>
                    <img src="<%= ResolveUrl(MonoSoftware.MonoX.Paths.App_Themes.img.Error_png) %>" alt="Warning" />
                    <h2><%= ErrorMessages.PageNotFound %>&nbsp;-&nbsp;<%= ErrorMessages.PageNotFoundRemovePersonalization %></h2>
                    <span><%= ErrorMessages.PageNotFoundPersonalizationFound %></span>
                </dd>
                <dd>                   
                    <MonoX:StyledButton ID="btnYes" runat="server" Text="<%$ Code:GlobalText.Yes %>"  />
                    <MonoX:StyledButton ID="btnNo" runat="server" Text="<%$ Code:GlobalText.No %>"  />
                </dd>
            </asp:PlaceHolder>
            <dd>
                <%= MonoSoftware.MonoX.Resources.ErrorMessages.ToContinueWorkingWithApplication %>
                <strong><asp:HyperLink ID="lnkHome" runat="server" NavigateUrl="~/"><%= ErrorMessages.ToContinueWorkingWithApplicationClickHere%></asp:HyperLink></strong>
            </dd>

    </div>
</asp:Content>
