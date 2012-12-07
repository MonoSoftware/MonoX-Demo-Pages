<%@ Page 
    Language="C#" 
    MasterPageFile="~/MonoX/MasterPages/Empty.master" 
    AutoEventWireup="true" 
    Inherits="MonoSoftware.MonoX.Pages.ActivationEmailRecovery" 
    Codebehind="ActivationEmailRecovery.aspx.cs" %>

<%@ MasterType TypeName="MonoSoftware.MonoX.BaseMasterPage" %>
<%@ Register TagPrefix="MonoX" TagName="ActivationEmailRecovery" Src="~/MonoX/ModuleGallery/Membership/ActivationEmailRecovery.ascx" %>

<asp:Content ContentPlaceHolderID="cp" Runat="Server">
    <div class="top-copyright">
        Copyright &#169;2012
        <a href="http://www.mono-software.com">Mono Ltd.</a>
        <a id="A1" runat="server" href="http://monox.mono-software.com" title="Powered by MonoX">Powered by MonoX</a>
    </div>
    <div class="empty-top-section">
        <a href='<%= MonoSoftware.Web.UrlFormatter.ResolveServerUrl(MonoSoftware.MonoX.Utilities.LocalizationUtility.RewriteLink("~/")) %>' class="logo">
            <img id="Img1" runat="server" src="<%$ Code: MonoSoftware.MonoX.Paths.App_Themes.img.logo_png %>" alt="MonoX" />
        </a>
    </div>
    <div class="container-fluid-small">
        <MonoX:ActivationEmailRecovery runat="server" ID="ctlActivationEmailRecovery" />
    </div>
</asp:Content>
