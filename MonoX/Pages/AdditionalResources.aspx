<%@ Page
    Language="C#"
    MasterPageFile="~/MonoX/MasterPages/Default.master"
    AutoEventWireup="true"
    Inherits="MonoSoftware.MonoX.Pages.AdditionalResources"
    Title="MonoX Resources"
    Codebehind="AdditionalResources.aspx.cs" %>

<%@ MasterType TypeName="MonoSoftware.MonoX.BaseMasterPage" %>   
<%@ Import Namespace="MonoSoftware.MonoX.Resources" %>
<%@ Register TagPrefix="MonoX" TagName="Editor" Src="~/MonoX/ModuleGallery/MonoXHtmlEditor.ascx" %>
<%@ Register Assembly="MonoX" Namespace="MonoSoftware.MonoX" TagPrefix="portal" %>

<asp:Content ID="content1" ContentPlaceHolderID="cp" Runat="Server">
    <div class="content-wrapper two-columns content-pages">
        <div class="side-content">
            <portal:PortalWebPartZoneTableless HeaderText='<%$ Code: PageResources.Zone_RightPartZone %>' ID="rightWebPartZone" runat="server" Width="100%" ChromeTemplateFile="RightColumn.htm" ShowChromeForNonAdmins="true">
                <ZoneTemplate>
                    <div class="info-box">
                    <MonoX:Editor runat="server" ID="editor1" Title='<%$ Code: PageResources.Title_Resources %>'>
                    <DefaultContent>
                    
                        <p>
                        MonoX is built upon standard ASP.NET tools and techniques, so there are many additional resources that will help you learn how to use it efficiently in the shortest amount of time. <br /><br />
                        This page presents MonoX documentation and additional resources on ASP.NET and Web part programming. Please do not hesitate to contact us if you need more information on these topics.
                        </p>
                    
                    </DefaultContent>
                    </MonoX:Editor>
                    </div>
                </ZoneTemplate>
            </portal:PortalWebPartZoneTableless>            
        </div>
        <div class="main-content additional-resources">
            <portal:PortalWebPartZoneTableless HeaderText='<%$ Code: PageResources.Zone_LeftPartZone %>' ID="leftPartZone" runat="server" Width="100%" ChromeTemplateFile="LeftColumn.htm">
                <ZoneTemplate>
                    <MonoX:Editor runat="server" ID="editor2" Title='<%$ Code: PageResources.Title_AdditionalResources %>'>
                    <DefaultContent>
                    <h2>MonoX documentation and samples</h2>
                        <ul class="list">
                        <li><a href="http://www.mono-software.com/Downloads/#MonoX" target="_blank">MonoX user manual</a></li>
                        <li><a href="http://www.mono-software.com/Downloads/#MonoX" target="_blank">MonoX API documentation</a></li>
                        <li><a href="http://www.mono-software.com/blog/post/Mono/104/How-to-perform-MonoX-installation/" target="_blank">How to install MonoX</a></li>
                        <li><a href="http://www.mono-software.com/Blog/post/Mono/95/Building-a-custom-ASP-NET-project-based-on-MonoX/" target="_blank">Building a custom ASP.NET project based on MonoX</a></li>
                        <li><a href="http://www.mono-software.com/Blog/post/Mono/93/Building-a-custom-Web-part/" target="_blank">Building a custom Web part</a></li>
                        <li><a href="~/MonoX/Samples/ConnectionSample/ConnectionSample.aspx" target="_blank">Web part connection sample</a></li>
                        <li><a href="~/MonoX/Samples/WebPartSample/WebPartSample.aspx" target="_blank">Web part sample</a></li>
                    </ul>
                    <h2>Books</h2>
                    <ul class="list">
                        <li><a href="http://www.amazon.com/gp/product/193239477X?ie=UTF8&amp;tag=monosoft-20&amp;linkCode=as2&amp;camp=1789&amp;creative=9325&amp;creativeASIN=193239477X" target="_blank">ASP.NET 2.0 Web Parts in Action: Building Dynamic Web Portals</a> (by Darren Neimke)</li>
                        <li><a href="http://www.lulu.com/content/804882" target="_blank">The Web Part Infrastructure Uncovered</a> (by Teun Duynstee)</li>
                        <li><a href="http://www.amazon.com/gp/product/0764584642?ie=UTF8&amp;tag=monosoft-20&amp;linkCode=as2&amp;camp=1789&amp;creative=9325&amp;creativeASIN=0764584642" target="_blank">ASP.NET 2.0 Website Programming: Problem - Design - Solution</a> (by Marco Bellinaso)</li>
                        <li><a href="http://www.amazon.com/gp/product/076457860X?ie=UTF8&amp;tag=monosoft-20&amp;linkCode=as2&amp;camp=1789&amp;creative=9325&amp;creativeASIN=076457860X" target="_blank">Professional Web Parts and Custom Controls with ASP.NET 2.0</a> (by Peter Vogel)</li>
                    </ul>
                    <h2>Articles</h2>
                    <ul class="list">
                        <li><a href="http://msdn.microsoft.com/en-us/library/e0s9t4ck.aspx" target="_blank">ASP.NET Web Parts Controls</a></li>
                        <li><a href="http://www.code-magazine.com/Article.aspx?quickid=0611031" target="_blank">ASP.NET 2.0 Web Part Infrastructure</a></li>
                        <li><a href="http://msdn.microsoft.com/hr-hr/magazine/cc163587(en-us).aspx" target="_blank">Asynchronous Web Parts</a></li>
                        <li><a href="http://www.ondotnet.com/pub/a/dotnet/2005/05/23/webparts_1.html" target="_blank">Building Web Parts</a></li>
                        <li><a href="http://www.c-sharpcorner.com/UploadFile/a_anajwala/Building_WebParts.mht08042005042119AM/Building_WebParts.mht.aspx" target="_blank">Building Web Parts in ASP.NET 2.0</a></li>
                        <li><a href="http://msdn.microsoft.com/en-us/library/ms379628.aspx" target="_blank">Introducing the ASP.NET 2.0 Web Parts Framework</a></li>
                        <li><a href="http://msdn.microsoft.com/en-us/magazine/cc300767.aspx" target="_blank">Personalize Your Portal with User Controls and Custom Web Parts</a></li>
                    </ul>
                    <h2>Webcasts</h2>
                    <ul class="list">
                        <li><a href="http://msevents.microsoft.com/CUI/WebCastEventDetails.aspx?EventID=1032266502&amp;EventCategory=5&amp;culture=en-US&amp;CountryCode=US" target="_blank">MSDN Events Reloaded - Microsoft ASP.NET 2.0 Overview (Level 200)</a></li>
                        <li><a href="http://msevents.microsoft.com/CUI/WebCastEventDetails.aspx?EventID=1032326987&amp;EventCategory=5&amp;culture=en-US&amp;CountryCode=US" target="_blank">MSDN Webcast: Introduction to ASP.NET 2.0 Web Part Framework (Level 300)</a></li>
                    </ul>
                    </DefaultContent>
                    </MonoX:Editor>
                </ZoneTemplate>
            </portal:PortalWebPartZoneTableless>

        </div>
    </div>
</asp:Content>