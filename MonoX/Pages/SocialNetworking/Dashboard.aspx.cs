using MonoSoftware.MonoX.Utilities;
using System;
using MonoSoftware.Core;

namespace MonoSoftware.MonoX.Pages.SocialNetworking
{
    public partial class Dashboard : BasePage
    {
        #region Page Events
        protected override void OnInit(EventArgs e)
        {
            this.SetPageTitle(MonoSoftware.MonoX.Resources.PageResources.Dashboard_Title);
            snWallNotes.NoteSaved += new EventHandler<EventArgs<Guid>>(snWallNotes_NoteSaved);
            base.OnInit(e);
        }

        protected override void OnLoad(EventArgs e)
        {
            ctlBlogPostList.UrlSingleBlogPost = UrlUtility.RewritePagePath(ctlBlogPostList.UrlSingleBlogPost, RewrittenPaths.BlogPost.DefaultPage);
            ctlNewGroups.DefaultPageName = RewrittenPaths.GroupList.DefaultPage;
            ctlNewTopics.TopicFilterType = DiscussionTopicFilter.LastActiveTopics;
            ctlNewTopics.BindData();
            snWallNotes.Visible = Page.User.Identity.IsAuthenticated;
            snWallNotes.AllowPostingNotes = Page.User.Identity.IsAuthenticated;
            base.OnLoad(e);
        }
        #endregion

        #region Methods
        void snWallNotes_NoteSaved(object sender, EventArgs<Guid> e)
        {
            ctlEvents.BindData();   
        }
        #endregion
    }
}
