using CS412Final_Azzawie.BLL;
using CS412Final_Azzawie.BLL.Interfaces;
using CS412Final_Azzawie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS412Final_Azzawie
{
    public partial class UserAds : System.Web.UI.Page
    {
        private readonly IAdBLL _AdBLL = new AdBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                // redirect to login if he is not loged in yet
                if (!Login.userSignedIn())
                {
                    Response.Redirect("./login.aspx");
                }

                ViewState["userAds"] = _AdBLL.GetUserAds();
                BindRepeater();
            }
        }



        private void BindRepeater()
        {
            publicAds.DataSource = ViewState["userAds"];
            publicAds.DataBind();
        }

        protected void publicAds_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                Ad ad = (Ad)e.Item.DataItem;
                ((Label)e.Item.FindControl("title")).Text = ad.Title;
                ((Label)e.Item.FindControl("price")).Text = ad.Price.ToString();
                ((Label)e.Item.FindControl("desc")).Text = ad.Description;
                ((Label)e.Item.FindControl("conition")).Text = ad.Condition;
            }
        }

    }
}