using System;
using MonoSoftware.Core;

namespace MonoSoftware.MonoX.Mobile
{
    public partial class Content : BaseMobilePage
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
