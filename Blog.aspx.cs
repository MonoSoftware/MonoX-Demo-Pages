using System;
using MonoSoftware.MonoX.Caching;
using MonoSoftware.MonoX.Resources;

namespace MonoSoftware.MonoX.Pages
{
    public partial class Blog : BasePage
    {
        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            if (this.CacheDuration > 0)
            {
                if (UrlParams.Blog.BlogSlug.HasValue)
                    this.CacheDependencyKeys = GetPageCacheKey(CacheKeys.Blog.CacheDependencyKey, UrlParams.Blog.BlogSlug.Value);
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            tagCloud.Title = BlogResources.Tags;
            blogCategories.Title = BlogResources.Categories;
            blogInfo.Title = BlogResources.BlogInfo;
            blogList.Title = BlogResources.BlogList;
            base.OnLoad(e);
        }
    }
}