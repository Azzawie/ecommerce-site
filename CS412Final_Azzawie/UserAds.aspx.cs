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
        private readonly List<Ad> ads = new List<Ad>()
            {
                new Ad(){
                    User = new User()
                    {
                        Id=1,
                        First= "Mustafa",
                        Last= "Azzawie",
                        Email="mmakialazzaw@neiu.edu",
                        Phone="1234567898"
                    },
                    Id= 1,
                    Title ="Iphone for sell",
                    Price = "120.5",
                    Description = "This is a brand new Iphone for sell, looking for good deal",
                    Condition = "New"
                },
               new Ad(){
                    User = new User()
                    {
                        Id=2,
                        First= "Mustafa2",
                        Last= "Azzawie2",
                        Email="2222@neiu.edu",
                        Phone="1234567898"
                    },
                    Id= 1,
                    Title ="Samsung for sell",
                    Price = "100.0",
                    Description = "New Samsung for sell",
                    Condition = "New"
                },
               new Ad(){
                    User = new User()
                    {
                        Id=3,
                        First= "Mustafa3",
                        Last= "Azzawie3",
                        Email="mmakialazzaw3@neiu.edu",
                        Phone="1234567898"
                    },
                    Id= 1,
                    Title ="Iphone for sell",
                    Price = "12.5",
                    Description = "Used Iphone for sell",
                    Condition = "Used"
                },
        };


        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                // redirect to login if he is not loged in yet
                if (!Login.userSignedIn())
                {
                    Response.Redirect("./login.aspx");
                }

                ViewState["users"] = ads;
                BindRepeater();
            }
        }



        private void BindRepeater()
        {
            publicAds.DataSource = ViewState["users"];
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