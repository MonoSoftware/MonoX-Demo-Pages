<%@ Page 
    Language="C#" 
    AutoEventWireup="true" 
    MasterPageFile="~/MonoX/MasterPages/Default.master"
    Inherits="MonoSoftware.MonoX.Pages.Default" 
    Title="MonoX - Portal Framework for ASP.NET" 
    Codebehind="Default.aspx.cs" %>
    
<%@ MasterType TypeName="MonoSoftware.MonoX.BaseMasterPage" %>   
 
<%@ Register TagPrefix="MonoX" TagName="Editor" Src="~/MonoX/ModuleGallery/MonoXHtmlEditor.ascx" %>
<%@ Register TagPrefix="MonoX" TagName="Rss" Src="~/MonoX/ModuleGallery/RssReader.ascx" %>
<%@ Register Assembly="MonoX" Namespace="MonoSoftware.MonoX" TagPrefix="portal" %> <%--Zona--%>
<%@ Register Assembly="MonoX" Namespace="MonoSoftware.MonoX.ModuleGallery" TagPrefix="ModuleGallery" %>
<%@ Register TagPrefix="MonoX" TagName="AdModule" Src="~/MonoX/ModuleGallery/AdModule.ascx"  %>
<%@ Register TagPrefix="MonoX" TagName="SlideShow" Src="~/MonoX/ModuleGallery/SlideShow.ascx"  %>


<%@ Import Namespace="MonoSoftware.MonoX.Resources" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cp" runat="server">
<div class="intro-colored-background">
    <div class="intro-background-picture">
        <div class="intro-wrapper">
            <div class="intro-headline">
                <h1>Free ASP.NET<br /> Content Management and Social Networking Platform</h1>
                <p>Fully responsive and adaptive to all desktop and mobile devices and platforms</p>
            </div>
            <div class="intro-image">
                <img id="Img3" src="~/App_Themes/Default/img/banner-image.png" runat="server" />
            </div>
        </div>
    </div>
    <div class="gray-bar"></div>
</div>

<div class="download-wrapper">
    <div class="download-holder">
        <a href="http://www.mono-software.com/Downloads/#MonoX" onclick="javascript:pageTracker._trackPageview('/Downloads/MonoX.zip');">
            <span>Download MonoX</span>
        </a>
    </div>
</div>

<div id="main-features" class="content-wrapper two-columns">
    <div class="main-content home-copy">
    <portal:PortalWebPartZoneTableless ID="middlePartZone" runat="server" Width="100%" ChromeTemplateFile="Standard.htm" HeaderText='<%$ Code: PageResources.Zone_MiddlePartZone %>'>
            <ZoneTemplate>
                <MonoX:Editor runat="server" ID="editor3" Title='<%$ Code: PageResources.Title_MiddleSection %>' DefaultDocumentTitle='<%$ Code: PageResources.Title_MiddleSection %>'>
                    <DefaultContent>
                                <h2>MonoX. <br />Fast. Powerful. Flexible. <em>And it comes at the price you cannot beat.</em></h2>
                                <p>Inspired by the latest Web technologies and built on top of the Web parts infrastructure, MonoX features an intuitive, user-friendly user interface that supports drag and drop editing, WYSIWYG interface, advanced templating engine and personalization. It provides everything you need to build fully-featured social environments, including user profiles, third-party authorization, user relationship modules, a multi-user blog engine with automatic anti-spam protection, photo albums, customizable group architecture, discussion boards, file galleries, support for activity streams, messaging, chat, video sharing, walls and comments. </p>
                                    
                    </DefaultContent>
                </MonoX:Editor>
            </ZoneTemplate>
        </portal:PortalWebPartZoneTableless>
    </div>
    <div class="side-content">
        <portal:PortalWebPartZoneTableless ID="topPartZone" runat="server" Width="100%" ChromeTemplateFile="Standard.htm" HeaderText='<%$ Code: PageResources.Zone_TopPartZone %>'>
        <ZoneTemplate>
            <MonoX:Editor runat="server" ID="editor2" Title='<%$ Code: PageResources.Title_TopSection %>' DefaultDocumentTitle='<%$ Code: PageResources.Title_TopSection %>'>
                <DefaultContent>
                    <div class="box highlited">
                        <div class="highlited-image"><img src="~/App_Themes/Default/img/content-icons/bubble-icon.png" /></div>
                        <div class="highlited-text">
                            <h3>Social Networking</h3>
                            <p>MonoX comes with everything you need to build advanced social networks.</p>
                            <p>
                                <a href="~/MonoX/Pages/Features.aspx?tab=tab-3">Find out more</a>
                            </p>
                        </div>
                    </div>
                    <div class="box highlited">
                        <div class="highlited-image"><img src="~/App_Themes/Default/img/content-icons/doc-icon.png" /></div>
                        <div class="highlited-text">
                            <h3>Content Management</h3>
                            <p>MonoX includes very powerful content management functionality.</p>
                            <p>
                                <a href="~/MonoX/Pages/Features.aspx?tab=tab-2">Find out more</a>
                            </p>
                        </div>
                    </div>
                    <div class="box highlited">
                        <div class="highlited-image"><img src="~/App_Themes/Default/img/content-icons/badge-icon.png" /></div>
                        <div class="highlited-text">
                            <h3>What's New</h3>
                            <p>Visit our change log to see what's been added in the recent versions.</p>
                            <p>
                                <a href="~/ContentPage/ChangeLog/">Find out more</a>
                            </p>
                        </div>
                    </div>
                </DefaultContent>
            </MonoX:Editor>
        </ZoneTemplate>
        </portal:PortalWebPartZoneTableless>
    </div>
</div>

<div class="gray-background">
    <div id="featured-projects" class="content-wrapper">
        <div class="main-content">
            <h2>Featured Projects</h2>
            <div class="home-slider">
                <ul data-orbit>
                    <li>
                        <img runat="server" src="~/App_Themes/Default/img/Projects/project-admovie.jpg" />
                    </li>
                    <li>
                        <img id="Img1" runat="server" src="~/App_Themes/Default/img/Projects/project-clipfair.jpg" />
                    </li>
                    <li>
                        <img id="Img2" runat="server" src="~/App_Themes/Default/img/Projects/project-cpl.jpg" />
                    </li>
                    <li>
                        <img id="Img4" runat="server" src="~/App_Themes/Default/img/Projects/project-edenrecruitment.jpg" />
                    </li>
                    <li>
                        <img id="Img5" runat="server" src="~/App_Themes/Default/img/Projects/project-gourus.jpg" />
                    </li>
                    <li>
                        <img id="Img6" runat="server" src="~/App_Themes/Default/img/Projects/project-home.jpg" />
                    </li>
                    <li>
                        <img id="Img7" runat="server" src="~/App_Themes/Default/img/Projects/project-jobsboard.jpg" />
                    </li>
                    <li>
                        <img id="Img8" runat="server" src="~/App_Themes/Default/img/Projects/project-mono-software.jpg" />
                    </li>
                    <li>
                        <img id="Img9" runat="server" src="~/App_Themes/Default/img/Projects/project-pitcheo.jpg" />
                    </li>
                    <li>
                        <img id="Img10" runat="server" src="~/App_Themes/Default/img/Projects/project-sbaopen.jpg" />
                    </li>
                    <li>
                        <img id="Img11" runat="server" src="~/App_Themes/Default/img/Projects/project-theorio.jpg" />
                    </li>
                    <li>
                        <img id="Img12" runat="server" src="~/App_Themes/Default/img/Projects/project-yoquiero.jpg" />
                    </li>
                </ul>
            </div>
        </div>
    </div>
</div>

<div id="features-list" class="content-wrapper">
    <portal:PortalWebPartZoneTableless ID="bottomWebPartZone" runat="server" Width="100%" ChromeTemplateFile="Standard.htm" HeaderText='<%$ Code: PageResources.Zone_BottomPartZone %>'>
        <ZoneTemplate>
            <MonoX:Editor runat="server" ID="editor1" Title='<%$ Code: PageResources.Title_BottomSection %>' DefaultDocumentTitle='<%$ Code: PageResources.Title_BottomSection %>' >
                <DefaultContent>
                        <div class="featured-box">
                            <a href="~/MonoX/Mobile/Default.aspx">
                                <span class="icon-mobile"></span>
                                <strong>MonoX Mobile</strong>
                                <p>You can go for a responsive design, or build a separate mobile version of your site.</p>
                            </a>
                        </div>
                        <div class="featured-box">
                            <a href="~/MonoX/Pages/News.aspx">
                                <span class="icon-news"></span>
                                <strong>News</strong>
                                <p>Quickly and easily present news and updates to your audience.</p>
                            </a>
                        </div>
                        <div class="featured-box">
                            <a href="~/MonoX/Pages/SocialNetworking/EventCalendar.aspx">
                                <span class="icon-calendar"></span>
                                <strong>Calendar</strong>
                                <p>Display and organize all kinds of events using an intuitive interface.</p>
                            </a>
                        </div>
                        <div class="featured-box">
                            <a href="~/MonoX/Pages/SocialNetworking/Dashboard.aspx">
                                <span class="icon-social"></span>
                                <strong>Social Dashboard</strong>
                                <p>Show the most important social networking features in one place.</p>
                            </a>
                        </div>
                        <div class="featured-box">
                            <a href="~/blog/posts/MonoX/">
                                <span class="icon-blog"></span>
                                <strong>Blogs</strong>
                                <p>Install a multi-user blog system with anti-spam protection and support for customization.</p>
                            </a>
                        </div>
                        <div class="featured-box">
                            <a href="~/MonoX/Pages/SocialNetworking/Discussion.aspx">
                                <span class="icon-board"></span>
                                <strong>Discussion Boards</strong>
                                <p>Engage in conversation with full support for commenting, voting and moderation.</p>
                            </a>
                        </div>
                        <div class="featured-box">
                            <a href="~/MonoX/Pages/SocialNetworking/PhotoGallery.aspx">
                                <span class="icon-gallery"></span>
                                <strong>Media galleries</strong>
                                <p>Host and share videos, photos, resumes, or any other kind of binary attachments.</p>
                            </a>
                        </div>
                        <div class="featured-box">
                            <a href="~/MonoX/Pages/SocialNetworking/Groups.aspx">
                                <span class="icon-groups"></span>
                                <strong>Groups</strong>
                                <p>Allow users to interact with each other around common topics.</p>
                            </a>
                        </div>
                </DefaultContent>    
            </MonoX:Editor>                
        </ZoneTemplate>
    </portal:PortalWebPartZoneTableless>
</div>
    <script type="text/javascript">
        $(document).foundation('orbit', { bullets: false, resume_on_mouseout: true, timer_speed: 5000, animation: 'fade', animation_speed: 250 });
    </script>
</asp:Content>