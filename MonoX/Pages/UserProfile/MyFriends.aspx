<%@ Page 
    Title=""
    Language="C#"
    MasterPageFile="~/MonoX/MasterPages/DefaultSmallHeader.master"
    AutoEventWireup="true"
    CodeBehind="MyFriends.aspx.cs"
    Inherits="MonoSoftware.MonoX.Pages.Profile.MyFriends" %>

<%@ MasterType TypeName="MonoSoftware.MonoX.BaseMasterPage" %>   
<%@ Import Namespace="MonoSoftware.MonoX.Resources" %>
<%@ Register TagPrefix="MonoX" TagName="PeopleSearch" Src="~/MonoX/ModuleGallery/SocialNetworking/PeopleSearch.ascx" %>
<%@ Register TagPrefix="MonoX" TagName="FriendList" Src="~/MonoX/ModuleGallery/SocialNetworking/FriendList.ascx" %>
<%@ Register TagPrefix="MonoX" TagName="FriendSuggestionsList" Src="~/MonoX/ModuleGallery/SocialNetworking/FriendSuggestionsList.ascx" %>
<%@ Register Assembly="MonoX" Namespace="MonoSoftware.MonoX" TagPrefix="portal" %>
<%@ Register TagPrefix="MonoX" TagName="ProfileHeader" Src="~/MonoX/ModuleGallery/ProfileModule/UserProfileHeader.ascx" %>
<%@ Register TagPrefix="MonoX" TagName="InvitationList" Src="~/MonoX/ModuleGallery/SocialNetworking/InvitationList.ascx" %>
<%@ Register TagPrefix="MonoX" TagName="BlockedUserList" Src="~/MonoX/ModuleGallery/SocialNetworking/BlockedUserList.ascx" %>
<%@ Register TagPrefix="MonoX" TagName="BlockUser" Src="~/MonoX/ModuleGallery/SocialNetworking/BlockUser.ascx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cp" runat="server">    
    <div class="row-fluid">
        <div class="friends">
            <div class="span12">
                <MonoX:ProfileHeader id="profileHeader" runat="server"></MonoX:ProfileHeader> 
            </div>
            <div class="row-fluid">
                <div class="span12">
                    <portal:PortalWebPartZoneTableless HeaderText='<%$ Code: PageResources.Zone_RightPartZone %>' ID="PortalWebPartZoneTableless2" runat="server" Width="100%" ChromeTemplateFile="RightColumnSimple.htm" ShowChromeForNonAdmins="true">
                        <ZoneTemplate>
                            <MonoX:FriendSuggestionsList ID="friendSuggestionsList" runat="server" NumberOfFriendSuggestions="12" ShowSearchBox="true" SuggestionMode="Shorten"></MonoX:FriendSuggestionsList>
                        </ZoneTemplate>
                    </portal:PortalWebPartZoneTableless>
                </div>
            </div>
            <div class="row-fluid">
                <div class="span8">
                    <portal:PortalWebPartZoneTableless HeaderText='<%$ Code: PageResources.Zone_RightPartZone %>' ID="rightWebPartZone" runat="server" Width="100%" ChromeTemplateFile="RightColumn.htm" ShowChromeForNonAdmins="true">
                        <ZoneTemplate>
                            <MonoX:FriendList runat="server" PageSize="20" AvatarSize="80" ID="snFriendList" ></MonoX:FriendList>
                        </ZoneTemplate>
                    </portal:PortalWebPartZoneTableless>
                </div>
                <div class="span4">
                    <portal:PortalWebPartZoneTableless HeaderText='<%$ Code: PageResources.Zone_RightPartZone %>' ID="PortalWebPartZoneTableless1" runat="server" Width="100%" ChromeTemplateFile="RightColumn.htm" ShowChromeForNonAdmins="true">
                        <ZoneTemplate>
                            <MonoX:PeopleSearch runat="server" ID="snPeopleSearch" ConfirmationRequired="true" />
                            <MonoX:InvitationList runat="server" InvitationType="InvitationsSent" ID="ctlInvitationsSent" PageSize="5" AvatarSize="40" HideIfEmpty="true" PagerTemplateName="PostbackPager" />
                            <MonoX:InvitationList runat="server" InvitationType="InvitationsReceived" ID="ctlInvitationsReceived" PageSize="5" AvatarSize="40" HideIfEmpty="true" PagerTemplateName="PostbackPager" />
                            <MonoX:BlockUser runat="server" ID="ctlBlockUser" ></MonoX:BlockUser>
                            <MonoX:BlockedUserList runat="server" ID="ctlBlockedUserList" PageSize="6" AvatarSize="40" PagerTemplateName="PostbackPager" ></MonoX:BlockedUserList>
                        </ZoneTemplate>
                    </portal:PortalWebPartZoneTableless>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
