<%@ Page 
    Language="C#" 
    MasterPageFile="~/MonoX/MasterPages/Empty.master" 
    AutoEventWireup="true" 
    Inherits="MonoSoftware.MonoX.Pages.Login" 
    Codebehind="Login.aspx.cs" %>
  
<%@ Import Namespace="MonoSoftware.MonoX.Resources"%>
<%@ MasterType TypeName="MonoSoftware.MonoX.BaseMasterPage" %>    
<%@ Register TagPrefix="MonoX" TagName="Login" Src="~/MonoX/ModuleGallery/LoginModule.ascx" %>
<%@ Register TagPrefix="MonoX" TagName="LoginSocial" Src="~/MonoX/ModuleGallery/LoginSocial.ascx" %>
<%@ Register TagPrefix="MonoX" TagName="MembershipNavigation" Src="~/MonoX/MasterPages/MembershipNavigation.ascx" %>

<asp:Content ContentPlaceHolderID="cp" Runat="Server">
    <div class="top-copyright">
        Copyright &#169;<%= DateTime.UtcNow.Year.ToString() %>
        <a href="http://www.mono-software.com">Mono Ltd.</a>
        <a id="A1" runat="server" href="http://monox.mono-software.com" title="Powered by MonoX">Powered by MonoX</a>
    </div>
    <div class="empty-top-section">
        <a href='<%= MonoSoftware.Web.UrlFormatter.ResolveServerUrl(MonoSoftware.MonoX.Utilities.LocalizationUtility.RewriteLink("~/")) %>' class="logo">
            <img id="Img1" runat="server" src="<%$ Code: MonoSoftware.MonoX.Paths.App_Themes.img.logo_png %>" alt="MonoX" />
        </a>        
        <div class="container-fluid-small">
            <asp:PlaceHolder ID="plhAuthorizationMessage" runat="server" Visible="false">
                <div class="error">
                    <div><img src="<%= ResolveUrl(MonoSoftware.MonoX.Paths.App_Themes.img.Error_png) %>" alt="Error" /></div>
                    <%= ErrorMessages.Authorization_Login %>
                </div>
            </asp:PlaceHolder>
        </div>
    </div>
    <div class="container-fluid-small">
        <div class="login-top">
            <div class="clearfix">
                <MonoX:MembershipNavigation runat="server" ID="ctlMemership" LoginStatusLogoutText="&nbsp;" />
                <MonoX:Login runat="server" ID="ctlLogin" Width="100%"  />
            </div>
        </div>
        <div id="rowRPX" runat="server" Visible="<% $Code: MonoSoftware.MonoX.ApplicationSettings.EnableUserRegistration && !Page.User.Identity.IsAuthenticated %>">
            <div class="or-use">
                <hr />
                <div><%= PageResources.Login_Or %></div>
            </div>
            <div class="user-account login-social" >
                <MonoX:LoginSocial runat="server" ID="ctlLoginSocial" />
                <div class="italic-style"><asp:Literal ID="Literal1" runat="server" Visible="<% $Code: MonoSoftware.MonoX.ApplicationSettings.EnableUserRegistration %>" Text="<% $Code: PageResources.Login_RpxWarning %>"></asp:Literal></div>
            </div>
        </div>
    </div>
</asp:Content>