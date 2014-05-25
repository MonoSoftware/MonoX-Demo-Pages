<%@ Page 
    Language="C#" 
    MasterPageFile="~/MonoX/MasterPages/Empty.master" 
    AutoEventWireup="true" 
    Inherits="MonoSoftware.MonoX.Pages.Register" 
    Codebehind="Register.aspx.cs" %>

<%@ MasterType TypeName="MonoSoftware.MonoX.BaseMasterPage" %>    
<%@ Register TagPrefix="MonoX" TagName="Membership" Src="~/MonoX/ModuleGallery/Membership/MembershipEditor.ascx" %>

<asp:Content ContentPlaceHolderID="cp" Runat="Server">
     <div class="content-wrapper" id="login-page">
        <div class="login-title">
            <a href='<%= MonoSoftware.Web.UrlFormatter.ResolveServerUrl(MonoSoftware.MonoX.Utilities.LocalizationUtility.RewriteLink("~/")) %>' class="logo">
                <img id="Img1" runat="server" src="<%$ Code: MonoSoftware.MonoX.Paths.App_Themes.img.logo_png %>" alt="MonoX" />
            </a>
        </div>
        <div class="page-login">
            <MonoX:Membership runat="server" ID="ctlMembershipEditor" />
        </div>
    </div>
    <footer id="sticky-footer">
        <div class="copyright">
            Copyright &#169;<%= DateTime.UtcNow.Year.ToString()%>
            <a href="http://www.mono-software.com">Mono Ltd.</a>
            <a id="A2" runat="server" href="http://monox.mono-software.com" title="Powered by MonoX">Powered by MonoX</a>
        </div>
    </footer>
</asp:Content>
