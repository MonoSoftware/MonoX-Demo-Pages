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
<%@ Register Assembly="MonoX" Namespace="MonoSoftware.MonoX" TagPrefix="portal" %>
<%@ Register Assembly="MonoX" Namespace="MonoSoftware.MonoX.ModuleGallery" TagPrefix="ModuleGallery" %>
<%@ Register TagPrefix="MonoX" TagName="AdModule" Src="~/MonoX/ModuleGallery/AdModule.ascx"  %>
<%@ Register TagPrefix="MonoX" TagName="SlideShow" Src="~/MonoX/ModuleGallery/SlideShow.ascx"  %>


<%@ Import Namespace="MonoSoftware.MonoX.Resources" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cp" runat="server">
    <div class="main">
        <div class="container">
            <div class="row-fluid">
                <div class="span6 clearfix">
                    <portal:PortalWebPartZoneTableless ID="topPartZone" runat="server" Width="100%" ChromeTemplateFile="Standard.htm" HeaderText='<%$ Code: PageResources.Zone_TopPartZone %>'>
                    <ZoneTemplate>
                        <MonoX:Editor runat="server" ID="editor2" Title='<%$ Code: PageResources.Title_TopSection %>' DefaultDocumentTitle='<%$ Code: PageResources.Title_TopSection %>'>
                            <DefaultContent>
                                <div class="what-box">
                                    <h3><span>01.</span> Social Networking</h3>
                                    <p>MonoX comes with everything you need to build advanced social networks.</p>
                                    <a href="~/MonoX/Pages/Features.aspx?tab=tab-3">
                                        Find out more
                                        <span class="arrow"></span>
                                    </a>
                                </div>
                                <div class="what-box">
                                    <h3><span>02.</span> Content Management</h3>
                                    <p>MonoX includes very powerful content management functionality.</p>
                                    <a href="~/MonoX/Pages/Features.aspx?tab=tab-2">
                                        Find out more
                                        <span class="arrow"></span>
                                    </a>
                                </div>
                                <div class="what-box">
                                    <h3><span>03.</span> What's New</h3>
                                    <p>Visit our change log to see what's been added in the recent versions.</p>
                                    <a href="~/ContentPage/ChangeLog/">
                                        Find out more
                                        <span class="arrow"></span>
                                    </a>
                                </div>
                                <div class="what-box">
                                    <h3><span>04.</span> More Information</h3>
                                    <p>Mono Software provides MonoX blogs, tutorials and support forums.</p>
                                    <a href="http://www.mono-software.com">
                                        Find out more
                                        <span class="arrow"></span>
                                    </a>
                                </div>
                            </DefaultContent>
                        </MonoX:Editor>
                    </ZoneTemplate>
                    </portal:PortalWebPartZoneTableless>
                </div>
                <div class="span6 clearfix" style="position: relative;">
                    <MonoX:SlideShow runat="server" ID="ctlSlideShow" Title='<%$ Code: PageResources.Title_RightSection %>'
                        NavigationNextCaption="<%$ Code: MonoSoftware.MonoX.Resources.DefaultResources.SlideShow_Next.ToUpper() %>" 
                        NavigationPreviousCaption="<%$ Code: MonoSoftware.MonoX.Resources.DefaultResources.SlideShow_Prev.ToUpper() %>"
                        SliderTitle="<%$ Code: MonoSoftware.MonoX.Resources.DefaultResources.SlideShow_Title.ToUpper() %>">
                        <SlideShowItems>
                            <ModuleGallery:SlideShowItem runat="server" ImageUrl="~/App_Themes/Default/img/Projects/project-mono-software.jpg" Url="http://www.mono-software.com" Title="Mono Software"></ModuleGallery:SlideShowItem>
                            <ModuleGallery:SlideShowItem runat="server" ImageUrl="~/App_Themes/Default/img/Projects/project-jobsboard.jpg" Url="http://www.jobsboard.ie" Title="JobsBoard"></ModuleGallery:SlideShowItem>
                            <ModuleGallery:SlideShowItem runat="server" ImageUrl="~/App_Themes/Default/img/Projects/project-edenrecruitment.jpg" Url="http://www.edenrecruitment.ie/" Title="Eden Recruitment"></ModuleGallery:SlideShowItem>
                            <ModuleGallery:SlideShowItem runat="server" ImageUrl="~/App_Themes/Default/img/Projects/project-pitcheo.jpg" Url="http://www.pitcheo.com" Title="Pitcheo"></ModuleGallery:SlideShowItem>
                            <ModuleGallery:SlideShowItem runat="server" ImageUrl="~/App_Themes/Default/img/Projects/project-cpl.jpg" Url="http://www.cpl.ie" Title="CPL"></ModuleGallery:SlideShowItem>
                            <ModuleGallery:SlideShowItem runat="server" ImageUrl="~/App_Themes/Default/img/Projects/project-dirh.jpg" Url="http://www.inspektorat.hr" Title="Inspektorat"></ModuleGallery:SlideShowItem>
                            <ModuleGallery:SlideShowItem runat="server" ImageUrl="~/App_Themes/Default/img/Projects/project-yoquierosermejor.jpg" Url="http://www.yoquierosermejor.com/" Title="Yoquierosermejor"></ModuleGallery:SlideShowItem>
                            <ModuleGallery:SlideShowItem runat="server" ImageUrl="~/App_Themes/Default/img/Projects/project-traenerguiden.jpg" Url="http://traenerguiden.dgi.dk/" Title="Traenerguiden"></ModuleGallery:SlideShowItem>
                            <ModuleGallery:SlideShowItem runat="server" ImageUrl="~/App_Themes/Default/img/Projects/project-sbaopen.jpg" Url="http://www.sbaopen.com" Title="sbaOpen"></ModuleGallery:SlideShowItem>
                            <ModuleGallery:SlideShowItem runat="server" ImageUrl="~/App_Themes/Default/img/Projects/project-as.jpg" Url="http://v2.anesthesiascheduler.com" Title="Anesthesia scheduler"></ModuleGallery:SlideShowItem>
                        </SlideShowItems>
                    </MonoX:SlideShow>
                </div>
            </div>
        </div>
        <div class="info-about">
            <div class="container">
                <div class="row-fluid">
                    <div class="span12" style="position: relative;">
                        <portal:PortalWebPartZoneTableless ID="middlePartZone" runat="server" Width="100%" ChromeTemplateFile="Standard.htm" HeaderText='<%$ Code: PageResources.Zone_MiddlePartZone %>'>
                            <ZoneTemplate>
                                <MonoX:Editor runat="server" ID="editor3" Title='<%$ Code: PageResources.Title_MiddleSection %>' DefaultDocumentTitle='<%$ Code: PageResources.Title_MiddleSection %>'>
                                    <DefaultContent>
                                
                                                <h1>
                                                    <span>Free</span> ASP.NET <span>Content Management</span> and <span>Social Networking</span> Platform
                                                    <i>Fast. Powerful. Flexible. At the price you cannot beat.</i>
                                                </h1>
                                                <p>Inspired by the latest Web technologies and built on top of the Web parts infrastructure, MonoX features an intuitive, user-friendly user interface that supports drag and drop editing, WYSIWYG interface, advanced templating engine and personalization. It provides everything you need to build fully-featured social environments, including user profiles, third-party authorization, user relationship modules, a multi-user blog engine with automatic anti-spam protection, photo albums, customizable group architecture, discussion boards, file galleries, support for activity streams, messaging, chat, video sharing, walls and comments. </p>
                                                <div class="download-section">
                                                    <a href="http://www.mono-software.com/Downloads/#MonoX" class="download-button" onclick="javascript:pageTracker._trackPageview('/Downloads/MonoX.zip');">
                                                        <span>
                                                            Download now
                                                        </span>
                                                    </a>
                                                </div>
                                                <div class="arrow"></div>
                                    
                                    </DefaultContent>
                                </MonoX:Editor>
                            </ZoneTemplate>
                        </portal:PortalWebPartZoneTableless>
                    </div>
                </div>
            </div>
        </div>
        <div class="container clearfix">
            <portal:PortalWebPartZoneTableless ID="bottomWebPartZone" runat="server" Width="100%" ChromeTemplateFile="Standard.htm" HeaderText='<%$ Code: PageResources.Zone_BottomPartZone %>'>
                <ZoneTemplate>
                    <MonoX:Editor runat="server" ID="editor1" Title='<%$ Code: PageResources.Title_BottomSection %>' DefaultDocumentTitle='<%$ Code: PageResources.Title_BottomSection %>' >
                        <DefaultContent>
                            <div class="boxes">
                                <div class="row-fluid">
                                    <div class="span3">
                                        <a href="~/MonoX/Mobile/Default.aspx" class="box">
                                            <img runat="server" src="~/App_Themes/Default/img/Icons/icon-1.png" alt="MonoX Mobile" class="scale-with-grid" />
                                            <strong>MonoX Mobile</strong>
                                            <span>You can go for a responsive design, or build a separate mobile version of your site.</span>
                                        </a>
                                    </div>
                                    <div class="span3">
                                        <a href="~/MonoX/Pages/News.aspx" class="box">
                                            <img runat="server" src="~/App_Themes/Default/img/Icons/icon-2.png" alt="News" class="scale-with-grid" />
                                            <strong>News</strong>
                                            <span>Quickly and easily present news and updates to your audience.</span>
                                        </a>
                                    </div>
                                    <div class="span3">
                                        <a href="~/MonoX/Pages/SocialNetworking/EventCalendar.aspx" class="box">
                                            <img runat="server" src="~/App_Themes/Default/img/Icons/icon-3.png" alt="Calendar" class="scale-with-grid" />
                                            <strong>Calendar</strong>
                                            <span>Display and organize all kinds of events using an intuitive interface.</span>
                                        </a>
                                    </div>
                                    <div class="span3">
                                        <a href="~/MonoX/Pages/SocialNetworking/Dashboard.aspx" class="box">
                                            <img runat="server" src="~/App_Themes/Default/img/Icons/icon-4.png" alt="Social dashboard" class="scale-with-grid" />
                                            <strong>Social Dashboard</strong>
                                            <span>Show the most important social networking features in one place.</span>
                                        </a>
                                    </div>
                                </div>
                                <div class="row-fluid">
                                    <div class="span3">
                                        <a href="~/blog/posts/MonoX/" class="box">
                                            <img runat="server" src="~/App_Themes/Default/img/Icons/icon-5.png" alt="Blogs" class="scale-with-grid" />
                                            <strong>Blogs</strong>
                                            <span>Install a multi-user blog system with anti-spam protection and support for customization.</span>
                                        </a>
                                    </div>
                                    <div class="span3">
                                        <a href="~/MonoX/Pages/SocialNetworking/Discussion.aspx" class="box">
                                            <img runat="server" src="~/App_Themes/Default/img/Icons/icon-6.png" alt="Discussion boards" class="scale-with-grid" />
                                            <strong>Discussion Boards</strong>
                                            <span>Engage in conversation with full support for commenting, voting and moderation.</span>
                                        </a>
                                    </div>
                                    <div class="span3">
                                        <a href="~/MonoX/Pages/SocialNetworking/PhotoGallery.aspx" class="box">
                                            <img runat="server" src="~/App_Themes/Default/img/Icons/icon-7.png" alt="Media galleries" class="scale-with-grid" />
                                            <strong>Media galleries</strong>
                                            <span>Host and share videos, photos, resumes, or any other kind of binary attachments.</span>
                                        </a>
                                    </div>
                                    <div class="span3">
                                        <a href="~/MonoX/Pages/SocialNetworking/Groups.aspx" class="box">
                                            <img runat="server" src="~/App_Themes/Default/img/Icons/icon-8.png" alt="Groups" class="scale-with-grid" />
                                            <strong>Groups</strong>
                                            <span>Allow users to interact with each other around common topics.</span>
                                        </a>
                                    </div>
                                </div>
                            </div>
                        </DefaultContent>    
                    </MonoX:Editor>                
                </ZoneTemplate>
            </portal:PortalWebPartZoneTableless>
        </div>
    </div>
</asp:Content>