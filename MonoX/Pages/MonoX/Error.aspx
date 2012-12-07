<%@ Page 
    Language="C#" 
    MasterPageFile="~/MonoX/MasterPages/Empty.master" 
    AutoEventWireup="true" 
    Inherits="MonoSoftware.MonoX.Pages.Error" 
    Codebehind="Error.aspx.cs" %>

<%@ MasterType TypeName="MonoSoftware.MonoX.BaseMasterPage" %>

<asp:Content ContentPlaceHolderID="cp" Runat="Server">
    <div class="top-copyright">
        Copyright &#169;2012
        <a href="http://www.mono-software.com">Mono Ltd.</a>
        <a id="A1" runat="server" href="http://monox.mono-software.com" title="Powered by MonoX">Powered by MonoX</a>
    </div>
    <div class="error-top-section">
        <div class="container-fluid-large">
            <img runat="server" src="~/App_Themes/Default/img/error-bg.jpg" alt="Error background" class="scale-with-grid" />
        </div>
    </div>
    <div class="error-bottom-section">
        <div class="container-fluid-large">
            <p><%= Description %></p>
            <h3><%= MonoSoftware.MonoX.Resources.ErrorMessages.ToContinueWorkingWithApplication %> <asp:HyperLink ID="lnkHome" runat="server" NavigateUrl="~/"></asp:HyperLink></h3>
        </div>
    </div>
</asp:Content>
