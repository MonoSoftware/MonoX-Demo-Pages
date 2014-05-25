<%@ Page
    Language="C#"
    AutoEventWireup="True"
    CodeBehind="Contact.aspx.cs"
    Inherits="MonoSoftware.MonoX.Pages.Contact"    
    MasterPageFile="~/MonoX/MasterPages/Default.master" %>
        
<%@ MasterType TypeName="MonoSoftware.MonoX.BaseMasterPage" %>   

<%@ Import Namespace="MonoSoftware.MonoX.Resources" %>
<%@ Register TagPrefix="MonoX" TagName="Editor" Src="~/MonoX/ModuleGallery/MonoXHtmlEditor.ascx" %>
<%@ Register TagPrefix="MonoX" TagName="ContactForm" Src="~/MonoX/ModuleGallery/ContactFormModule.ascx" %>
<%@ Register Assembly="MonoX" Namespace="MonoSoftware.MonoX" TagPrefix="portal" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cp" runat="server">
    <div class="content-wrapper">
        <div class="main-content">
            <portal:PortalWebPartZoneTableless HeaderText='<%$ Code: PageResources.Zone_ContentZone %>' ID="contentPartZone" runat="server" Width="100%" ChromeTemplateFile="Standard.htm">
                <ZoneTemplate>
                    <MonoX:ContactForm ID="ctlContact" runat="server" 
                    A_WebSiteName="MonoX CMS Demo (Mono Ltd.)" A_Address="Bihacka 1d" A_City="Osijek" 
                    A_ZipCode="31000" A_Country="Croatia" A_Phone="+385 31 213 966" A_Fax="+385 31 213 967"  EnableSSL="false" A_EMail="info@domain.com"           
                    ></MonoX:ContactForm>
                </ZoneTemplate>
            </portal:PortalWebPartZoneTableless>
        </div>
    </div>
</asp:Content>