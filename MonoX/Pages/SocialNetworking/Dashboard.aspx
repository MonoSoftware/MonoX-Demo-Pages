<%@ Page
    Language="C#"
    AutoEventWireup="True"
    CodeBehind="Dashboard.aspx.cs"
    Inherits="MonoSoftware.MonoX.Pages.SocialNetworking.Dashboard"
    MasterPageFile="~/MonoX/MasterPages/Default.master"
    MaintainScrollPositionOnPostback="true" %>
        
<%@ MasterType TypeName="MonoSoftware.MonoX.BaseMasterPage" %>   

<%@ Import Namespace="MonoSoftware.MonoX.Resources" %>
<%@ Register TagPrefix="MonoX" TagName="Wall" Src="~/MonoX/ModuleGallery/SocialNetworking/WallNotes.ascx" %>
<%@ Register Assembly="MonoX" Namespace="MonoSoftware.MonoX" TagPrefix="portal" %>
<%@ Register TagPrefix="MonoX" TagName="Events" Src="~/MonoX/ModuleGallery/SocialNetworking/Events.ascx" %>
<%@ Register TagPrefix="MonoX" TagName="FriendSuggestionsList" Src="~/MonoX/ModuleGallery/SocialNetworking/FriendSuggestionsList.ascx" %>
<%@ Register TagPrefix="MonoX" TagName="BlogPostList" Src="~/MonoX/ModuleGallery/Blog/BlogPostList.ascx" %>
<%@ Register TagPrefix="MonoX" TagName="NewGroups" Src="~/MonoX/ModuleGallery/SocialNetworking/Groups/NewGroupsList.ascx" %>
<%@ Register TagPrefix="MonoX" TagName="DiscussionTopic" Src="~/MonoX/ModuleGallery/SocialNetworking/Discussion/DiscussionTopics.ascx" %>  
    
<asp:Content ID="Content1" ContentPlaceHolderID="cp" runat="server">
    <div class="dashboard">
        <div class="content-wrapper two-columns">
            <div class="main-content">
                <portal:PortalWebPartZoneTableless HeaderText='<%$ Code: PageResources.Zone_SocialZone %>' ID="activityPartZone" runat="server" Width="100%" ChromeTemplateFile="Standard.htm">
                <ZoneTemplate>
                    <MonoX:Wall runat="server" ID="snWallNotes" UsePrettyPhoto="true" ShowRating="false" GravatarRenderType="NotSet" WallNoteListVisible="false"  />                        
                    <MonoX:Events ID="ctlEvents" runat="server" PageSize="20" PagingEnabled="true" ></MonoX:Events>
                </ZoneTemplate>
                </portal:PortalWebPartZoneTableless>
            </div>
            <div class="side-content">
                <portal:PortalWebPartZoneTableless HeaderText='<%$ Code: PageResources.Zone_SocialZone %>' ID="connectPartZone" runat="server" Width="100%" ChromeTemplateFile="RightColumn.htm" ShowChromeForNonAdmins="true">
                <ZoneTemplate>
                    <MonoX:FriendSuggestionsList ID="friendSuggestionsList" runat="server" NumberOfFriendSuggestions="8" ShowSearchBox="true" SuggestionMode="Shorten"></MonoX:FriendSuggestionsList>
                    <MonoX:BlogPostList ID="ctlBlogPostList" RetainBreaksInDescription="false" CacheDuration="600" RewritePageTitle="false" Template="BlogPostListShort" runat="server" RssEnabled="true" IsHeaderVisible="False" MaxDescriptionChars="90" PageSize="5" MaxTitleChars="40" PagingEnabled="false" /> 
                    <MonoX:NewGroups runat="server" ID="ctlNewGroups" CacheDuration="600" PagingEnabled="false" MaxDescriptionChars="90" AvatarSize="32" PageSize="5"></MonoX:NewGroups>  
                    <MonoX:DiscussionTopic runat="server" ID="ctlNewTopics" EnableInsertNewTopic="false" EnableAnswering="false" EnableOwnerDeleteOperation="false" EnablePaging="false" 
                        TopicSorter="SortNewTopicsOnTop" ShowBackLink="false" TopicFilterType="LastActiveTopics" Template="DiscussionTopicList" PageSize="5" HeaderVisible="false" EnableDiscussionDefaultUrl="true"  />
                </ZoneTemplate>
                </portal:PortalWebPartZoneTableless>
            </div>
        </div>
    </div>
</asp:Content>