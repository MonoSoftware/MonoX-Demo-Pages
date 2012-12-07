using System;
using System.Web.Security;
using System.Security;
using MonoSoftware.MonoX.Utilities;
using MonoSoftware.Web;
using MonoSoftware.Core;

namespace MonoSoftware.MonoX.Pages
{
    public partial class AccountActivation : BasePage
    {
        #region Properties
        private string _accountActivatedMessagePageUrl = ApplicationSettings.MessagePageUrl;
        /// <summary>
        /// Gets or sets the account activated message url.
        /// </summary>
        public string AccountActivatedMessagePageUrl
        {
            get
            {
                return _accountActivatedMessagePageUrl;
            }
            set
            {
                _accountActivatedMessagePageUrl = value;
            }
        }

        private string _accountActivatedTitle = Resources.DefaultResources.Message_AccountActivated_Title;
        /// <summary>
        /// Gets or sets the account activated title message.
        /// </summary>
        public string AccountActivatedTitle
        {
            get
            {
                return _accountActivatedTitle;
            }
            set
            {
                _accountActivatedTitle = value;
            }
        }

        private string _accountActivatedDescription = Resources.DefaultResources.Message_AccountActivated_Description;
        /// <summary>
        /// Gets or sets the account activated message url.
        /// </summary>
        public string AccountActivatedDescription
        {
            get
            {
                return _accountActivatedDescription;
            }
            set
            {
                _accountActivatedDescription = value;
            }
        } 
        #endregion

        #region Page Events
        protected override void OnInit(EventArgs e)
        {
            OnUserActivating(new EventArgs<Guid?>(UrlParams.UserId.HasValue ? UrlParams.UserId.Value.Guid : default(Guid?)));
            base.OnInit(e);
        } 
        #endregion

        #region Method
        /// <summary>
        /// Raised when user's activation process begins.
        /// </summary>
        /// <param name="e">Event arguments with User Id</param>
        protected virtual void OnUserActivating(EventArgs<Guid?> e)
        {
            if (e.Value.HasValue)
            {
                MembershipUser membershipUser = Membership.GetUser(e.Value.Value);
                if (membershipUser != null)
                {
                    membershipUser.IsApproved = true;
                    Membership.UpdateUser(membershipUser);
                    FormsAuthentication.SetAuthCookie(membershipUser.UserName, UrlParams.CreatePersistentCookie.Value.GetValueOrDefault());
                    Response.Redirect(LocalizationUtility.RewriteLink(Request.Url.AbsolutePath).Remove(UrlParams.UserId));
                }
                else
                {
                    throw new ApplicationException(Resources.DefaultResources.ErrorMessage_ActivationUrl);
                }
            }
            else
            {
                if (!User.Identity.IsAuthenticated)
                {
                    throw new SecurityException();
                }
                else
                {
                    Message.Show(AccountActivatedTitle, AccountActivatedDescription, LocalizationUtility.RewriteLink(AccountActivatedMessagePageUrl, true));
                }
            }
        }
        #endregion
    }
}
