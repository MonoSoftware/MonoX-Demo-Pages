using System;
using MonoSoftware.MonoX.Utilities;

namespace MonoSoftware.MonoX.Pages
{

    public partial class Features : BasePage
    {
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            JavascriptUtility.RegisterClientScriptInclude(this, Paths.MonoX.Scripts.purl_js);
        }
    }
}
