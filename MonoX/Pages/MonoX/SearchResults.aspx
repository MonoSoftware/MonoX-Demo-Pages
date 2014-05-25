<%@ Page 
    Language="C#" 
    MasterPageFile="~/MonoX/MasterPages/Default.master" 
    AutoEventWireup="true"     
    Inherits="MonoSoftware.MonoX.BasePage" 
    Title="" 
    %>
<%@ MasterType TypeName="MonoSoftware.MonoX.BaseMasterPage" %> 
<%@ Import Namespace="MonoSoftware.MonoX.Resources" %>  
<%@ Register TagPrefix="MonoX" TagName="Editor" Src="~/MonoX/ModuleGallery/MonoXHtmlEditor.ascx" %>
<%@ Register TagPrefix="MonoX" TagName="Search" Src="~/MonoX/ModuleGallery/MonoXSearchResult.ascx" %>
<%@ Register Assembly="MonoX" Namespace="MonoSoftware.MonoX" TagPrefix="portal" %>
<%@ Register Assembly="MonoX" Namespace="MonoSoftware.MonoX.SearchEngine" TagPrefix="Search" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cp" runat="server">
  
<div class="content-wrapper">
    <div class="main-content">
        <div class="title-holder">
            <h1><%= PageResources.Title_SearchResults %></h1>
        </div>
        <portal:PortalWebPartZoneTableless HeaderText='<%$ Code: PageResources.Zone_RightPartZone %>' ID="rightPartZone" runat="server" Width="100%" ChromeTemplateFile="Standard.htm" ShowChromeForNonAdmins="false">
            <ZoneTemplate>
                <MonoX:Search ID="search1" runat="server" Title='<%$ Code: PageResources.Title_SearchResults %>'>
                    <SearchProviderItems>
                        <Search:SearchProviderItem Name="PagesSearchProvider" Template="Default"></Search:SearchProviderItem>
                        <Search:SearchProviderItem Name="BlogSearchProvider" Template="Default"></Search:SearchProviderItem>
                        <Search:SearchProviderItem Name="DiscussionSearchProvider" Template="Default"></Search:SearchProviderItem>
                        <Search:SearchProviderItem Name="NewsSearchProvider" Template="Default"></Search:SearchProviderItem>
                        <Search:SearchProviderItem Name="UserProfileSearchProvider" Template="Default"></Search:SearchProviderItem>
                        <Search:SearchProviderItem Name="PhotoGallerySearchProvider" Template="Default"></Search:SearchProviderItem>
                        <Search:SearchProviderItem Name="GroupSearchProvider" Template="Default"></Search:SearchProviderItem>
                                <Search:SearchProviderItem Name="CalendarEventSearchProvider" Template="Default"></Search:SearchProviderItem>
                    </SearchProviderItems>
                </MonoX:Search>
            </ZoneTemplate>
        </portal:PortalWebPartZoneTableless>
    </div>
</div>

</asp:Content>