using System;
using System.Security;
using DotNetOpenAuth.OAuth.Messages;
using MonoSoftware.MonoX.DAL.EntityClasses;
using OpenSocial.Service;

namespace MonoSoftware.MonoX.OpenSocial
{
    public partial class OpenSocialAuthorizationPage : BasePage
    {
		#region Properties
        private OaTokenEntity _currentToken = null;
        protected OaTokenEntity CurrentToken
        {
            get
            {
                if (_currentToken == null)
                {
                    ITokenContainingMessage requestTokenMessage = OpenSocialOAuthServiceProvider.PendingAuthorizationRequest;
                    _currentToken = (OaTokenEntity)OpenSocialOAuthServiceProvider.ServiceProvider.TokenManager.GetRequestToken(requestTokenMessage.Token);
                }

                return _currentToken;
            }
        } 
        #endregion

        #region Page Events
        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            if (!Page.User.Identity.IsAuthenticated)
            {
                throw new SecurityException();
            }

            btnAllow.Text = MonoSoftware.MonoX.Resources.DefaultResources.OpenSocial_Allow;
            btnDeny.Text = MonoSoftware.MonoX.Resources.DefaultResources.OpenSocial_Deny;

            btnAllow.Click += new EventHandler(btnAllow_Click);
            btnDeny.Click += new EventHandler(btnDeny_Click);            
        }
        #endregion

        #region UI Events
        protected virtual void btnDeny_Click(object sender, EventArgs e)
        {
            OpenSocialOAuthServiceProvider.PendingAuthorizationRequest = null;
        }

        protected virtual void btnAllow_Click(object sender, EventArgs e)
        {
            // Use OpenSocialOAuthServiceProvider for handling OAuth tokens
            var tokenManager = OpenSocialOAuthServiceProvider.ServiceProvider.TokenManager;
            // Pending authorization request is passed through session
            var pendingRequest = OpenSocialOAuthServiceProvider.PendingAuthorizationRequest;

            var requestToken = CurrentToken;

            requestToken.UserId = MonoSoftware.MonoX.Utilities.SecurityUtility.GetUserId();
            // You can set token expiration date using requestToken.ExpirationDate 
            // e.g. requestToken.ExpirationDate = DateTime.UtcNow.AddHours(3);
            // Use requestToken.Scope for a scope of permissions requested
            tokenManager.UpdateToken(requestToken);
            
            var response = OpenSocialOAuthServiceProvider.AuthorizePendingRequestTokenAsWebResponse();
            if (response != null)
            {
                // The consumer provided a callback URL that can take care of everything else.
                response.Send();
            }
        } 
        #endregion
    }
}
