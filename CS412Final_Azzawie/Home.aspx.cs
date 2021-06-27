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
    public partial class Home : System.Web.UI.Page
    {
        private readonly IAdBLL _AdBLL = new AdBLL();


        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                ViewState["ads"] = _AdBLL.GetAds();
                BindRepeater();
            }
        }

        private void BindRepeater()
        {
            publicAds.DataSource = ViewState["ads"];
            publicAds.DataBind();
        }

        protected void publicAds_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                Ad ad = (Ad)e.Item.DataItem;
                ((Label)e.Item.FindControl("title")).Text = ad.Title;
                ((Label)e.Item.FindControl("price")).Text = ad.Price;
                ((Label)e.Item.FindControl("desc")).Text = ad.Description;
                ((Label)e.Item.FindControl("conition")).Text = ad.Condition;       
            }
        }
    }
}