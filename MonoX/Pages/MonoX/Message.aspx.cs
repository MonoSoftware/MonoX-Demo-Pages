using System;
using System.Web;
using MonoSoftware.Web;
using System.Net;
using System.Web.UI.WebControls.WebParts;

namespace MonoSoftware.MonoX
{
    /// <summary>
    /// Used for displaying various informal messages by executing the target message page and retain the original URL in the address bar.
    /// </summary>
    public partial class Message : BasePage
    {
        public const string contextKeyTitle = "__MonoSoftware.MonoX.Pages.Message.Title";
        public const string contextKeyDescription = "__MonoSoftware.MonoX.Pages.Message.Description";

        /// <summary>
        /// Gets the message title from the http context items.
        /// </summary>
        protected new string Title
        {
            get { return HttpContext.Current.Items[contextKeyTitle] as string; }
        }

        /// <summary>
        /// Gets the message description from the http context items.
        /// </summary>
        protected string Description
        {
            get { return HttpContext.Current.Items[contextKeyDescription] as string; }
        }

        /// <summary>
        /// Displays the message. Uses the message page URL form the web.config (MessagePageUrl).
        /// </summary>
        /// <param name="message">Message content.</param>
        public static void Show(string message)
        {
            Show(String.Empty, message);
        }

        /// <summary>
        /// Displays the message. Uses the message page URL form the web.config (MessagePageUrl).
        /// </summary>
        /// <param name="message">Message content.</param>
        /// <param name="statusCode"></param>
        public static void Show(string message, HttpStatusCode statusCode)
        {
            Show(String.Empty, message, ApplicationSettings.MessagePageUrl, statusCode);
        }

        /// <summary>
        /// Displays the message. Uses the message page URL form the web.config (MessagePageUrl).
        /// </summary>
        /// <param name="title">Message page title.</param>
        /// <param name="description">Message content.</param>
        public static void Show(string title, string description)
        {
            Show(title, description, ApplicationSettings.MessagePageUrl);
        }

         /// <summary>
        /// Displays the message and returns a status code to the calling browser. Usually used to display a warning text along with the proper HTTP code - for example, when a custom 404 error is to be displayed to the user, but with proper 404 code sent in response headers (as oposed to IIS custom error page that returns 302+200).
        /// Should skip the IIS custom error pages when used in IIS 7 integrated mode.
        /// Message page URL is passed as a path parameter.
        /// </summary>
        /// <param name="title">Message page title.</param>
        /// <param name="description">Message content.</param>
        /// <param name="path">Relative URL of the message page to execute.</param>
        /// <param name="statusCode">Status code to return to the calling browser (200 for OK, 404 for page not found, etc).</param>
        public static void Show(string title, string description, string path, HttpStatusCode statusCode)
        {
            Show(title, description, path, (int)statusCode);
        }

        /// <summary>
        /// Displays the message and returns a status code to the calling browser. Usually used to display a warning text along with the proper HTTP code - for example, when a custom 404 error is to be displayed to the user, but with proper 404 code sent in response headers (as oposed to IIS custom error page that returns 302+200).
        /// Should skip the IIS custom error pages when used in IIS 7 integrated mode.
        /// Message page URL is passed as a path parameter.
        /// </summary>
        /// <param name="title">Message page title.</param>
        /// <param name="description">Message content.</param>
        /// <param name="path">Relative URL of the message page to execute.</param>
        /// <param name="statusCode">Status code to return to the calling browser (200 for OK, 404 for page not found, etc).</param>
        public static void Show(string title, string description, string path, int statusCode)
        {
            if ((title != HttpContext.Current.Items[contextKeyTitle] as string) ||
                (description != HttpContext.Current.Items[contextKeyDescription] as string))
            {
                HttpContext.Current.Items[contextKeyTitle] = title;
                HttpContext.Current.Items[contextKeyDescription] = description;
                HttpContext.Current.Response.Clear();
                HttpContext.Current.Server.Execute(path);
                if (statusCode != 0 && statusCode != 200)
                {
                    HttpContext.Current.Response.TrySkipIisCustomErrors = true;
                    HttpContext.Current.Response.StatusCode = statusCode;
                }
                HttpContext.Current.Response.End();
            }
        }

        /// <summary>
        /// Displays the message. Message page URL is passed as a path parameter.
        /// </summary>
        /// <param name="title">Message page title.</param>
        /// <param name="description">Message content.</param>
        /// <param name="path">Relative URL of the message page to execute.</param>
        public static void Show(string title, string description, string path)
        {
            Show(title, description, path, HttpStatusCode.OK);
        }

        protected override void OnPreInit(EventArgs e)
        {
            this.InitWebPartManager += new EventHandler(Message_InitWebPartManager);
            base.OnPreInit(e);

        }

        void Message_InitWebPartManager(object sender, EventArgs e)
        {
            //to avoid the error "Personalization is not enabled and/or modifiable..." for non-authenticated users
            WebPartManager wpm = sender as WebPartManager;
            wpm.Personalization.Enabled = User.Identity.IsAuthenticated;
        }

        protected override void OnLoad(EventArgs e)
        {            
            this.Response.SetFormActionUrl(ResolveUrl(Request.AppRelativeCurrentExecutionFilePath));
            this.Page.Title = this.Title;
            base.OnLoad(e);
        }
    }
}
