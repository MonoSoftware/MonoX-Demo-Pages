using MonoSoftware.MonoX.Resources;
using System;
using MonoSoftware.MonoX.Utilities;

namespace MonoSoftware.MonoX.Pages.SocialNetworking
{
    public partial class Groups : BasePage
    {
        #region Properties
        /// <summary>
        /// Gets a value indicating whether we are on the Group home page.
        /// </summary>
        protected bool IsHome
        {
            get
            {
                return (UrlParams.SocialNetworking.Groups.InternalWorkingMode.HasValue && UrlParams.SocialNetworking.Groups.InternalWorkingMode.Value.Equals(SnGroupWorkingMode.Wall)) ||
                    !UrlParams.SocialNetworking.Groups.InternalWorkingMode.HasValue;
            }
        }
        #endregion

        #region Page Events
        protected override void OnInit(EventArgs e)
        {
            ctlGroupInfo.Title = PageResources.Groups_GroupInfo;
            ctlGroupMemberList.Title = PageResources.Groups_GroupMembers;
            ctlPeopleSearch.Title = PageResources.Module_PeopleSearch;
            ctlSearchGroups.Title = PageResources.Groups_SearchGroups;
            ctlSearchGroups.DefaultSearchText = PageResources.Groups_SearchGroups_DefaultSearchText;
            ctlGroupContainer.Title = PageResources.Groups_GroupContainer;
            ctlInvitationsSent.Title = PageResources.Groups_InvitationsSent;
            ctlInvitationsReceived.Title = PageResources.Groups_InvitationsReceived;

            if (UrlParams.SocialNetworking.Groups.GroupId.HasValue)
            {
                ctlGroupInfo.Visible = true;
                ctlGroupMemberList.Visible = true;
                ctlPeopleSearch.Visible = true;
                ctlSearchGroups.Visible = true;
                ctlInvitationsSent.Visible = true;
                ctlInvitationsReceived.Visible = true;
            }
            else
            {
                ctlGroupInfo.Visible = false;
                ctlGroupMemberList.Visible = false;
                ctlPeopleSearch.Visible = false;
                ctlSearchGroups.Visible = true;
                ctlInvitationsSent.Visible = false;
                ctlInvitationsReceived.Visible = false;
            }

            this.SetPageTitle(MonoSoftware.MonoX.Resources.PageResources.Groups_Title);
            base.OnInit(e);
        }

        protected override void OnPreRender(EventArgs e)
        {
            //only group admins can see the invitation module
            if (ctlInvitationsSent.Visible)
                ctlInvitationsSent.Visible = ctlPeopleSearch.CheckUserPrivileges();
            if (ctlInvitationsReceived.Visible)
                ctlInvitationsReceived.Visible = ctlPeopleSearch.CheckUserPrivileges();
            plhHome.Visible = IsHome;
            base.OnPreRender(e);
        } 
        #endregion
    }
}
