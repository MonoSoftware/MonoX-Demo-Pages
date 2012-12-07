using MonoSoftware.MonoX.Resources;
using System;

namespace MonoSoftware.MonoX.Pages.SocialNetworking
{
    public partial class Messages : BasePage
    {
        protected override void OnInit(EventArgs e)
        {            
            //messageList.MessageAddressTemplate = new FullNameAddressTemplate();
            //messageList.MessageAddressFormat = MonoSoftware.MonoX.Controls.UserAddressFormat.Username;
            this.SetPageTitle(MonoSoftware.MonoX.Resources.PageResources.Messages_Title);
            messageList.Title = PageResources.Module_Messages;
            snPeopleSearch.Title = PageResources.Module_PeopleSearch;
            snFriendList.Title = PageResources.Module_Friends;
            base.OnInit(e);
        }
    }

    // <summary>
    // This class implements a typical address entry item template; in this case it is full name template and is used if the MessageaAddressFormat is set to fullname
    // </summary>
    //public class FullNameAddressTemplate : ITemplate
    //{
    //    public void InstantiateIn(Control container)
    //    {
    //        PlaceHolder ph = new PlaceHolder();
    //        Literal ltlName = new Literal();
    //        ltlName.ID = "fullName";
    //        ph.Controls.Add(ltlName);
    //        ph.DataBinding += new EventHandler(Item_DataBinding);
    //        container.Controls.Add(ph);
    //    }
    //    public static void Item_DataBinding(object sender, EventArgs e)
    //    {
    //        PlaceHolder ph = (PlaceHolder)sender;
    //        RadComboBoxItem item = (RadComboBoxItem)ph.NamingContainer;
    //        string fullName = (string)DataBinder.Eval(item.DataItem, "FullName");
    //        ((Literal)ph.FindControl("fullName")).Text = fullName;
    //    }
    //}

}
