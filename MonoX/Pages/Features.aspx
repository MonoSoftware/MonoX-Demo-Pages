<%@ Page
    Language="C#"
    MasterPageFile="~/MonoX/MasterPages/DefaultSmallHeader.master"
    AutoEventWireup="true"
    Inherits="MonoSoftware.MonoX.Pages.Features"
    Title="MonoX Features"
    Codebehind="Features.aspx.cs" %>

<%@ MasterType TypeName="MonoSoftware.MonoX.BaseMasterPage" %>   
 
<%@ Register TagPrefix="MonoX" TagName="Editor" Src="~/MonoX/ModuleGallery/MonoXHtmlEditor.ascx" %>
<%@ Register TagPrefix="MonoX" TagName="FileGallery" Src="~/MonoX/ModuleGallery/SocialNetworking/FileGallery.ascx" %>
<%@ Register Assembly="MonoX" Namespace="MonoSoftware.MonoX" TagPrefix="portal" %>
<%@ Register Assembly="MonoX" Namespace="MonoSoftware.MonoX.Repositories" TagPrefix="MonoRepositories" %>
<%@ Import Namespace="MonoSoftware.MonoX.Resources" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cp" Runat="Server">
    <asp:HiddenField ID="hdnSelectedTab" runat="server" Value="" />
    <script type="text/javascript">
        $(document).ready(function () {
            if (isPostBack() == false && $.url().param('tab') != null)
                $("#<%= hdnSelectedTab.ClientID %>").val("#" + $.url().param('tab'));
            SetupTabs();
            var prm = Sys.WebForms.PageRequestManager.getInstance();
            if (prm != null) {
                prm.add_endRequest(function (s, e) {
                    SetupTabs();
                });
            }
        });
        
        function isPostBack() {
            return <%= Page.IsPostBack.ToString().ToLower() %>;
        }

        function SetupTabs () {
            $('#tabs .tab-container').hide();
            if ($("#<%= hdnSelectedTab.ClientID %>").val() == "") {
                $('#tabs .tab-container:first').show();
                $('#tabs ul li:first').addClass('active');
            }
            else {
                $($("#<%= hdnSelectedTab.ClientID %>").val()).show();
                $($("#<%= hdnSelectedTab.ClientID %>").val()).parent().addClass('active');
            }
            $('#tabsInner ul li a').click(function () {
                $('#tabs ul li').removeClass('active');
                $(this).parent().addClass('active');

                var currentTab = $(this).attr('href');
                if (currentTab != "#")
                    $("#<%= hdnSelectedTab.ClientID %>").val(currentTab);

                $('#tabs .tab-container').hide();
                $($("#<%= hdnSelectedTab.ClientID %>").val()).show();
                return false;
            });
        }
    </script>

    <div id="tabs" class="row-fluid features clearfix">
        <div id="tabsInner" class="span4">
            <ul class="side-menu">
                <li>
                    <a href="#tab-1">
                        Technical Features
                        <span class="arrow"></span>
                    </a>
                </li>
                <li>
                    <a href="#tab-2">
                        CMS Features
                        <span class="arrow"></span>
                    </a>
                </li>
                <li>
                    <a href="#tab-3">
                        Social Features
                        <span class="arrow"></span>
                    </a>
                </li>
                <li>
                    <a href="#tab-4">
                        Built-in Web Parts
                        <span class="arrow"></span>
                    </a>
                </li>
                <li>
                    <a href="#tab-5">
                        Performance
                        <span class="arrow"></span>
                    </a>
                </li>
                <li>
                    <a href="#tab-6">
                        Interoperability
                        <span class="arrow"></span>
                    </a>
                </li>
                <li>
                    <a href="#tab-7">
                        Licensing and Support
                        <span class="arrow"></span>
                    </a>
                </li>
            </ul>
            <div class="info-box">
                <h1>Free ASP.NET CMS and SN Platform</h1>
                MonoX provides tools for quick and intuitive construction of dynamic and fully editable ASP.NET portals, social networks and similar Web applications. For more details, please download the user manual.
                <span class="arrow"></span>
            </div>
            <a href="http://www.mono-software.com/Downloads/#MonoX" target="_blank" class="styled-button">download the user manual</a>
        </div>
        <div id="tab-1" class="span8 tab-container">
            <portal:PortalWebPartZoneTableless HeaderText='<%$ Code: PageResources.Zone_LeftPartZone %>' ID="tabOne" runat="server" Width="100%" ChromeTemplateFile="Standard.htm">
                <ZoneTemplate>
                    <MonoX:Editor runat="server" ID="editor1" Title='<%$ Code: PageResources.Title_DescriptionOfFeatures %>' ShowRating="false">
                    <DefaultContent>
                        <h2>Technical Features</h2>
                        <p>
                            <strong>Full support for the <a href="http://msdn.microsoft.com/en-us/library/e0s9t4ck.aspx" target="_blank">ASP.NET Web Parts Framework</a></strong><br />
                            Web Parts Framework includes a set of controls and services that specifically target the growing demand for Web portal creation, including support for personalization, membership, communication and other infrastructural tasks. MonoX is built on top of the standard Web Part API.
                        </p>
                        <p>
                            <strong>Commitment to standards</strong><br />
                            MonoX renders XHTML compliant code and enables users to develop fully standards-compliant portals that will work reliably on different platforms.
                        </p>
                        <p>
                            <strong>Unlimited design flexibility</strong><br />
                            Developers can create user interface templates without any limitations, using their favorite approach (tables, DIVs, CSS, ...). ASP.NET master pages, themes and templates are fully supported.
                        </p>
                        <p>
                            <strong>Open API</strong><br />
                            MonoX allows developers to access all of its back-end functionality through a comprehensive set of fully documented methods and events.
                        </p>
                        <p>
                            <strong><a href="http://msdn.microsoft.com/en-us/library/aa479030.aspx" target="_blank">Provider-based</a> architecture</strong><br />
                            An ASP.NET provider is a software module that provides a uniform interface between a service and a data source. Providers abstract physical storage media, in much the same way that device drivers abstract physical hardware devices. MonoX uses the provider model extensively, making it easy to add new functionality and interface with other ASP.NET applications.
                        </p>
                        <p>
                            <strong>Support for localization</strong><br />
                            All content and user interface elements can be localized at run time using only browser-based administrative tools. In addition to the standard .NET localization infrastructure, MonoX can store all localization resources in a portal database.
                        </p>
                        <p>
                            <strong>Advanced module communication</strong><br />
                            Developers can design sophisticated and elaborate Web part communication scenarios using the module communication support.
                        </p>
                        <p>
                            <strong>Development flexibility</strong><br />
                            All MonoX Web parts are in essence standard ASP.NET user controls. This allows developers to leverage their experience without the need to learn about new APIs and development environments. Controls are registered with the portal just by placing them in the module gallery folder. Additionally, there is an actual underlying file for each page, making it easy to customize the behavior of each portal page just like it is an ordinary ASPX page.
                        </p>
                        <p>
                            <strong>Multi-portal environments</strong><br />
                            Unlimited number of portals can be served from a single portal database.
                        </p>
                        <p>
                            <strong>Advanced personalization infrastructure</strong><br />
                            MonoX builds upon the personalization system that is integrated into ASP.NET 2.0, enabling users to personalize their working environment on both user and shared levels.
                        </p>
                    </DefaultContent>
                    </MonoX:Editor>
                </ZoneTemplate>
            </portal:PortalWebPartZoneTableless>
        </div>
        <div id="tab-2" class="span8 tab-container">
            <portal:PortalWebPartZoneTableless HeaderText='<%$ Code: PageResources.Zone_LeftPartZone %>' ID="tabTwo" runat="server" Width="100%" ChromeTemplateFile="Standard.htm">
                <ZoneTemplate>
                    <MonoX:Editor runat="server" ID="editor2" Title='<%$ Code: PageResources.Title_DescriptionOfFeatures %>' ShowRating="false">
                    <DefaultContent>
                        <h2>Content Management Features</h2>
                        <p>
                            <strong>Browser-based administration</strong><br />
                            All aspects of a portal can be managed through an online, browser-based interface.
                        </p>
                        <p>
                            <strong>User friendly Web 2.0 interface</strong><br />
                            MonoX provides modern and uncluttered Ajax-based user interface with intuitive look and feel. Web parts can be moved and edited using a convinient drag and drop interface.
                        </p>
                        <p>
                            <strong>WYSIWYG approach</strong><br />
                            A unique editor interface allows administrators to enter and update content "in-place" and to immediatelly see the results of their actions.
                        </p>
                        <p>
                            <strong>Windows Live Writer support</strong><br />
                            Microsoft Windows Live Writer is a free desktop application that makes it easier to compose compelling blog posts using numerous blog services. It features true offline WYSIWYG blog authoring and photo/map publishing.
                            MonoX fully supports Windows Live Writer and other similar editing tools that recognize standard MetaWeblog API, not only for the blog publishing tasks, but also for more general portal editing and configuration actions.
                        </p>
                        <p>
                            <strong>Content versioning</strong><br />
                            All changes made on a portal page can be saved for later approval and publishing.
                        </p>
                        <p>
                            <strong>RSS feed providers</strong><br />
                            All content-based modules (HTML editor, news system) can automatically provide RSS feeds.
                        </p>
                        <p>
                            <strong>Search Engine Optimization (SEO)</strong><br />
                            MonoX includes powerful Search Engine Optimization (SEO) techniques that can help users place their portals very high on all major search engines: ViewState optimization, URL rewriting, HTTP compression, SiteMap generation, automatic META keywords generation, integration with Google Analytics, compact and standards-compliant output...
                        </p>
                        <p>
                            <strong>Search infrastructure</strong><br />
                            MonoX comes with numerous search providers that give you a total control over the portal search engine behavior and performance. Included are providers that search pages, news, blog posts, groups, user profiles and file system.
                        </p>
                        <p>
                            <strong>Cloud data providers</strong><br />
                            MonoX now includes a data provider that hooks into <a href="http://aws.amazon.com/s3/" target="_blank">Amazon S3</a>, allowing users to store their data in the cloud and not on a local database or file servers.
                        </p>
                    </DefaultContent>
                    </MonoX:Editor>
                </ZoneTemplate>
            </portal:PortalWebPartZoneTableless>
        </div>
        <div id="tab-3" class="span8 tab-container">
            <portal:PortalWebPartZoneTableless HeaderText='<%$ Code: PageResources.Zone_LeftPartZone %>' ID="tabThree" runat="server" Width="100%" ChromeTemplateFile="Standard.htm">
                <ZoneTemplate>
                    <MonoX:Editor runat="server" ID="editor3" Title='<%$ Code: PageResources.Title_DescriptionOfFeatures %>' ShowRating="false">
                    <DefaultContent>
                        <h2>Social Networking Features</h2>
                        <p>
                            <strong>User profiles</strong><br />
                            Profiles are often used as a point of contact betwen users, and MonoX provides flexible architecture and modules to publish information about its users in a convinient way, respecting their privacy settings. You can choose between <a href="http://www.gravatar.com/" target="_blank">Gravatar</a> service and local avatar repository to attach personal photos to profiles.
                        </p>  
                        <p>
                            <strong>Support for OpenID and RPX</strong><br />
                            OpenID allows you to log-in to MonoX-based portals and applications without performing the time consuming registration process and remembering your credentials. <a href="http://aws.amazon.com/s3/" target="_blank">RPX</a> goes even further by integrating major online services, so you will be able to log in by using your credentials from Facebook, LinkedIn, MySpace and other major social networking systems.
                        </p> 
                        <p>
                            <strong>Friendship modules</strong><br />
                            Different terms describe the "friendship" or "connection" concept for different community types, but in all cases it is the fundamental feature of all social networks. MonoX provides a flexible set of modules for displaying and managing user friend lists.
                        </p>  
                        <p>
                            <strong>Blog engine</strong><br />
                            MonoX now includes a fully featured multi-user blog engine with support for comments, ratings, tagging and automatic anti-spam protection. Each user can have unlimited number of blogs, blog posts, tags and categories. 
                        </p>  
                        <p>
                            <strong>Photo albums</strong><br />
                            Each portal user can upload and organize photos using the album infrastructure. Thumbnails for common image file types are generated on the fly and stored on the server.
                        </p>  
                        <p>
                            <strong>Groups</strong><br />
                            Groups allow users of your community to interact with each other around a common topic. Modules such as walls, forums, albums, file galleries can all be utilized in the group context.
                        </p>  
                        <p>
                            <strong>Discussion boards</strong><br />
                            MonoX discussion boards allow users to easily post messages and comments to the community in a way that all the responses will be viewable no matter how much time passes between each post.
                        </p>
                        <p>
                            <strong>Media galleries</strong><br />
                            Many social networking sites are very dependant upon media galleries, as they could draw the large percentage of visitors back to the site. MonoX support a generic architecture that allows you to host videos, photos, resumes, or any other kind of physical files.
                        </p>        
                        <p>
                            <strong>Activity streams</strong><br />
                            Users can track the activity of their friends and be instantly notified when somebody publishes an interesting blog post, uploads a photo, joins the community...
                        </p>             
                        <p>
                            <strong>Messaging</strong><br />
                            Messaging is essential to all community sites as it allows users to communicate with each another (or a whole group) directly, resembling the look and feel of traditional mail clients.
                        </p>      
                        <p>
                            <strong>Video conversion and sharing</strong><br />
                            In addition to standard media gallery functionality, MonoX supports third-party plug-ins for video conversion that allow users to upload any kind of video material and have it coverted to standard Flash formats.
                        </p>        
                        <p>
                            <strong>Walls</strong><br />
                            Wall is a kind of virtual space on every user's profile or group page that allows friends to post messages for other users to see. In essence, this is usually the central gathering point for all users of a community. 
                        </p>       
                        <p>
                            <strong>Comments</strong><br />
                            Comment modules allow your users to interact with the content and other members of your social network. Our flexible infrastructure enables administrators to attach comments to virtually any kind of content: wall notes, blog posts, images, etc. 
                        </p>       
                        <p>
                            <strong>Ratings</strong><br />
                            Ratings can be a very important part of any community-based content site. They allow the whole community to be in charge of what content takes precedence on the site.
                        </p>       
                        <p>
                            <strong>Tags</strong><br />
                            Similar to comments and ratings, tags can be attached to different types of content, allowing users to build an independant form of navigation and/or categorization. 
                        </p>
                    </DefaultContent>
                    </MonoX:Editor>
                </ZoneTemplate>
            </portal:PortalWebPartZoneTableless>
        </div>
        <div id="tab-4" class="span8 tab-container">
            <portal:PortalWebPartZoneTableless HeaderText='<%$ Code: PageResources.Zone_LeftPartZone %>' ID="tabFour" runat="server" Width="100%" ChromeTemplateFile="Standard.htm">
                <ZoneTemplate>
                    <MonoX:Editor runat="server" ID="editor4" Title='<%$ Code: PageResources.Title_DescriptionOfFeatures %>' ShowRating="false">
                    <DefaultContent>
                        <h2>Other Built-in Web Parts</h2>
                        <p>
                            <strong>Advertisments</strong><br />
                            Allows users to set up and serve unlimited number of ad campaigns.
                        </p>
                        <p>
                            <strong>News system</strong><br />
                            MonoX includes several pre-built news-related Web parts. All of these modules are integrated with the news management back end section of the portal.
                        </p>
                        <p>
                            <strong>File upload</strong><br />
                            File upload Web part provides functionality for uploading unlimited number of files to the Web server. End user is available to select files to upload one by one, and than upload them all in a single step. An alternative Silverlight-based upload part provides even better user experience and interactivity.
                        </p>
                        <p>
                            <strong>HTML editor</strong><br />
                            HTML editor is one of the most-often used Web parts. It allow users to interactively edit the contents of the portal, and to immediately see the results in the WYSIWYG fashion.
                        </p>
                        <p>
                            <strong>Login</strong><br />
                            Login Web part allows administrators to quickly set up the login screen of their applications.
                        </p>
                        <p>
                            <strong>Menu</strong><br />
                            Menu Web part allows administrators to easily produce navigation menus on their portals. The navigation structure of a portal can be defined in the page management section. 
                        </p>
                        <p>
                            <strong>Poll</strong><br />
                            Allows users to set up an unlimited number of polls and simple surveys.
                        </p>
                        <p>
                            <strong>RSS reader</strong><br />
                            RSS is an acronym that stands for Really Simple Syndication and it has become a popular means of distributing and reading information from around the Web. RSS reader Web part allows users to easily consume information from unlimited number of RSS sources.
                        </p>
                        <p>
                            <strong>Search</strong><br />
                            Search Web part offers a very powerful and flexible functionality for creating local search engine for the various types of content. It also supports templating techniques, allowing administrators to tightly integrate this part wherever it is needed, while achieving the desired appearance and behavior.
                        </p>
                        <p>
                            <strong>List</strong><br />
                            Allows administrators to manage all list-based information: FAQs, link lists, user testimonials, and similar.
                        </p>
                        <p>
                            <strong>Newsletter</strong><br />
                            Enables administrators to create and send newsletters to target subscriber groups.
                        </p>
                    </DefaultContent>
                    </MonoX:Editor>
                </ZoneTemplate>
            </portal:PortalWebPartZoneTableless>
        </div>
        <div id="tab-5" class="span8 tab-container">
            <portal:PortalWebPartZoneTableless HeaderText='<%$ Code: PageResources.Zone_LeftPartZone %>' ID="tabFive" runat="server" Width="100%" ChromeTemplateFile="Standard.htm">
                <ZoneTemplate>
                    <MonoX:Editor runat="server" ID="editor5" Title='<%$ Code: PageResources.Title_DescriptionOfFeatures %>' ShowRating="false">
                    <DefaultContent>
                        <h2>Performance</h2>
                        <p>
                            <strong>Advanced caching</strong><br />
                            MonoX administrators can fine-tune the caching system on both page and Web part-level to reduce the access time and increase application responsiveness.
                        </p>
                        <p>
                            <strong>Viewstate optimization</strong><br />
                            MonoX can completely remove the contents of the ViewState hidden form field. It practically means that your page will be much "lighter" in terms of size and load times, as ViewState hidden field can hold tens of kilobytes of data even in moderately complex applications. All this is possible without loosing any of the ViewState-related functionality.
                        </p>
                        <p>
                            <strong>HTTP compression</strong><br />
                            Each portal page or related resource can be compressed on the fly, reducing the impact on the bandwidth and page load times.
                        </p>
                        <p>
                            <strong>High-performance, flexible data layer</strong><br />
                            MonoX utilizes <a href="http://www.llblgen.com" target="_blank">LLBLGen</a>, a powerful object-relational engine that generates highly optimized, robust and scalable database-related code.
                        </p>
                    </DefaultContent>
                    </MonoX:Editor>
                </ZoneTemplate>
            </portal:PortalWebPartZoneTableless>
        </div>
        <div id="tab-6" class="span8 tab-container">
            <portal:PortalWebPartZoneTableless HeaderText='<%$ Code: PageResources.Zone_LeftPartZone %>' ID="tabSix" runat="server" Width="100%" ChromeTemplateFile="Standard.htm">
                <ZoneTemplate>
                    <MonoX:Editor runat="server" ID="editor6" Title='<%$ Code: PageResources.Title_DescriptionOfFeatures %>' ShowRating="false">
                    <DefaultContent>
                        <h2>Interoperability</h2>
                        <p>
                            <strong>Integration with third-party modules and applications</strong><br />
                            An additional benefit of the provider model used in MonoX is that all ASP.NET applications that use it can be easily integrated with MonoX. Integrating excellent third-party applications like <a href="http://www.dotnetblogengine.net/" target="_blank">BlogEngine.Net</a> and <a href="http://www.yetanotherforum.net/" target="_blank"> YetAnotherForum.NET</a> is only a matter of few configuration changes in the Web.config files of these applications (full examples can be downloaded from the support site).
                        </p>
                        <p>
                            <strong>RSS</strong><br />
                            Administrators without technical experience can easily set up both RSS providers and consumers in MonoX and enable it to exchange information with external applications.
                        </p>
                    </DefaultContent>
                    </MonoX:Editor>
                </ZoneTemplate>
            </portal:PortalWebPartZoneTableless>
        </div>
        <div id="tab-7" class="span8 tab-container">
            <portal:PortalWebPartZoneTableless HeaderText='<%$ Code: PageResources.Zone_LeftPartZone %>' ID="tabSeven" runat="server" Width="100%" ChromeTemplateFile="Standard.htm">
                <ZoneTemplate>
                    <MonoX:Editor runat="server" ID="editor7" Title='<%$ Code: PageResources.Title_DescriptionOfFeatures %>' ShowRating="false">
                    <DefaultContent>
                        <h2>Licensing and Support</h2>
                        <p>
                            <strong>Licensing</strong><br />
                            MonoX is totally free for both commercial and non-commercial usage scenarios. You pay only if you need framework's <a href="http://www.mono-software.com/purchase/MonoX/" target="_blank">source code or a dedicated priority support contract</a>. More details can be found at our <a href="~/ContentPage/Licensing/" title="licensing page">licensing page</a>. 
                        </p>
                        <p>
                            <strong>Tradition</strong><br />
                            First commercial release of MonoX was released in 2004. It introduced drag and drop and visual configuration features that are now accepted in the Microsoft's official Web part framework. It was voted as a runner-up in the prestigious <a href="http://devproconnections.com/development/people-have-spoken-30-oct-2009-0" target="_blank">asp.netPRO Reader's Choice Awards</a>.
                        </p>
                        <p>
                            <strong>Deployed portals</strong><br />
                            MonoX powers dozens of portals and similar Web applications around the world. It has served as a foundation for custom-built distance learning, eGovernment, eCommerce, document management, knowledge management, human resource management and other types of applications.
                        </p>
                    </DefaultContent>
                    </MonoX:Editor>
                </ZoneTemplate>
            </portal:PortalWebPartZoneTableless>
        </div>
    </div>
</asp:Content>

