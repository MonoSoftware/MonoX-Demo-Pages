<%@ Page 
    Language="C#"
    AutoEventWireup="true"
    CodeBehind="Groups.aspx.cs"
    Inherits="MonoSoftware.MonoX.Pages.SocialNetworking.Groups"
    MasterPageFile="~/MonoX/MasterPages/Default.master"    
%>
<%@ MasterType TypeName="MonoSoftware.MonoX.BaseMasterPage" %>   
<%@ Import Namespace="MonoSoftware.MonoX.Resources" %>
<%@ Import Namespace="MonoSoftware.MonoX" %>
<%@ Register TagPrefix="MonoX" TagName="PeopleSearch" Src="~/MonoX/ModuleGallery/SocialNetworking/Groups/GroupPeopleSearch.ascx" %>
<%@ Register TagPrefix="MonoX" TagName="MemberList" Src="~/MonoX/ModuleGallery/SocialNetworking/Groups/GroupMemberList.ascx" %>
<%@ Register TagPrefix="MonoX" TagName="InvitationList" Src="~/MonoX/ModuleGallery/SocialNetworking/Groups/GroupInvitationList.ascx" %>
<%@ Register TagPrefix="MonoX" TagName="GroupContainer" Src="~/MonoX/ModuleGallery/SocialNetworking/Groups/GroupContainer.ascx" %>
<%@ Register TagPrefix="MonoX" TagName="GroupInfo" Src="~/MonoX/ModuleGallery/SocialNetworking/Groups/GroupInfo.ascx" %>
<%@ Register TagPrefix="MonoX" TagName="GroupSearch" Src="~/MonoX/ModuleGallery/SocialNetworking/Groups/GroupSearch.ascx" %>
<%@ Register Assembly="MonoX" Namespace="MonoSoftware.MonoX" TagPrefix="portal" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cp" Runat="Server">
    <div class="content-wrapper two-columns group">
        <div class="<%= IsHome ? "group-two-quarters" : "group-full-width" %>">
            <portal:PortalWebPartZoneTableless Orientation="Vertical" HeaderText='<%$ Code: PageResources.Zone_LeftPartZone %>' ID="leftPartZone" runat="server" Width="100%" ChromeTemplateFile="LeftColumn.htm">
                <ZoneTemplate>
                    <MonoX:GroupContainer runat="server" ID="ctlGroupContainer" GravatarRenderType="NotSet" />                        
                </ZoneTemplate>
            </portal:PortalWebPartZoneTableless>
        </div>
        <asp:PlaceHolder ID="plhHome" runat="server">
            <div class="side-content">
                <portal:PortalWebPartZoneTableless HeaderText='<%$ Code: PageResources.Zone_RightPartZone %>' ID="rightWebPartZone" runat="server" Width="100%" ChromeTemplateFile="RightColumn.htm" ShowChromeForNonAdmins="true">
                    <ZoneTemplate>
                        <MonoX:GroupInfo runat="server" CacheDuration="600" ID="ctlGroupInfo" />
                        <MonoX:GroupSearch runat="server" ID="ctlSearchGroups" />
                        <MonoX:MemberList runat="server" CacheDuration="600" PageSize="9" AvatarSize="40" ID="ctlGroupMemberList"></MonoX:MemberList>
                        <MonoX:PeopleSearch runat="server" CacheDuration="600" ConfirmationRequired="true" ID="ctlPeopleSearch" />
                        <MonoX:InvitationList runat="server" InvitationType="InvitationsSent" ID="ctlInvitationsSent" PageSize="9" AvatarSize="40" HideIfEmpty="true" />
                        <MonoX:InvitationList runat="server" InvitationType="InvitationsReceived" ID="ctlInvitationsReceived" PageSize="9" AvatarSize="40" HideIfEmpty="true" />
                    </ZoneTemplate>
                </portal:PortalWebPartZoneTableless>
            </div>
        </asp:PlaceHolder>
    </div>
</asp:Content>