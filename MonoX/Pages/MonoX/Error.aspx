<%@ Page 
    Language="C#" 
    MasterPageFile="~/MonoX/MasterPages/Empty.master" 
    AutoEventWireup="true" 
    Inherits="MonoSoftware.MonoX.Pages.Error" 
    Codebehind="Error.aspx.cs" %>

<%@ MasterType TypeName="MonoSoftware.MonoX.BaseMasterPage" %>

<asp:Content ContentPlaceHolderID="cp" Runat="Server">
<div class="content-wrapper"> 
    
    <div class="page-login">
        <h1><%= MonoSoftware.MonoX.Resources.ErrorMessages.ErrorPage_Title %></h1>
        <p><%= MonoSoftware.MonoX.Resources.ErrorMessages.ErrorPage_SubTitle %></p>
    </div>
    <div class="page-login">
        <p><%= Description %></p>
        <h3><%= MonoSoftware.MonoX.Resources.ErrorMessages.ToContinueWorkingWithApplication %> <asp:HyperLink ID="lnkHome" runat="server" NavigateUrl="~/"></asp:HyperLink></h3>
    </div>
</div>
    <footer id="sticky-footer">
        <div class="copyright">
            Copyright &#169;<%= DateTime.UtcNow.Year.ToString() %>
            <a href="http://www.mono-software.com">Mono Ltd.</a>
            <a id="A1" runat="server" href="http://monox.mono-software.com" title="Powered by MonoX">Powered by MonoX</a>
        </div>
    </footer>

</asp:Content>
