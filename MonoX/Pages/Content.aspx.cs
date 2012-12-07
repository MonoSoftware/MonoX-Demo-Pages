using MonoSoftware.Core;
using System;

namespace MonoSoftware.MonoX.Pages
{
    public partial class Content : BasePage
    {
        protected override void OnLoad(EventArgs e)
        {            
            ctlEditor.DocumentReady += new EventHandler<EventArgs<MonoSoftware.MonoX.DAL.EntityClasses.DocumentEntity>>(ctlEditor_DocumentReady);
            if (UrlParams.HtmlEditorDocumentContentId.HasValue)
                ctlEditor.ContentId = UrlParams.HtmlEditorDocumentContentId.Value;
            base.OnLoad(e);
        }

        void ctlEditor_DocumentReady(object sender, EventArgs<MonoSoftware.MonoX.DAL.EntityClasses.DocumentEntity> e)
        {
            if (e.Value != null)
            {
                ltlTitle.Text = e.Value.Title;
                this.SetPageTitle(e.Value.Title);
            }
        }


    }
}
