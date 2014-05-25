<%@ Page 
    Title=""
    Language="C#"
    MasterPageFile="~/MonoX/MasterPages/Default.master"
    AutoEventWireup="true"
    CodeBehind="MyPhotos.aspx.cs"
    Inherits="MonoSoftware.MonoX.Pages.Profile.MyPhotos"
    %>
<%@ MasterType TypeName="MonoSoftware.MonoX.BaseMasterPage" %>   
<%@ Import Namespace="MonoSoftware.MonoX.Resources" %>
<%@ Register Assembly="MonoX" Namespace="MonoSoftware.MonoX" TagPrefix="portal" %>
<%@ Register TagPrefix="MonoX" TagName="ProfileHeader" Src="~/MonoX/ModuleGallery/ProfileModule/UserProfileHeader.ascx" %>
<%@ Register TagPrefix="MonoX" TagName="PhotoGalleryContainer" Src="~/MonoX/ModuleGallery/SocialNetworking/PhotoGallery/PhotoGalleryContainer.ascx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cp" runat="server">    

        <MonoX:ProfileHeader id="profileHeader" runat="server"></MonoX:ProfileHeader> 
        <div class="content-wrapper">
            <div class="main-content">
                <portal:PortalWebPartZoneTableless HeaderText='<%$ Code: PageResources.Zone_LeftPartZone %>' ID="leftPartZone" runat="server" Width="100%" ChromeTemplateFile="Standard.htm" >
                    <ZoneTemplate>    
                        <MonoX:PhotoGalleryContainer runat="server" ID="snPhotoGallery" UsePrettyPhoto="true" PageSize="7" GravatarRenderType="NotSet" AlbumsButtonVisible="false" MyAlbumsButtonVisible="false" />
                    </ZoneTemplate>
                </portal:PortalWebPartZoneTableless>
            </div>
        </div>

</asp:Content>
