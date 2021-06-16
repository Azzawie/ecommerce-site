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
        private readonly List<Ad> ads = new List<Ad>()
            {
                new Ad(){
                    User = new User()
                    {
                        Id=1,
                        First= "first_1",
                        Last= "last_1",
                        Email="email_1@neiu.edu",
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
                        First= "first_2",
                        Last= "last_2",
                        Email="emai2_1@neiu.edu",
                        Phone="1234567898"
                    },
                    Id= 2,
                    Title ="Piano for sell",
                    Price = "220.5",
                    Description = "This is a brand new Piano for sell, looking for good deal",
                    Condition = "New"
                },
                
                new Ad(){
                    User = new User()
                    {
                        Id=3,
                        First= "first_3",
                        Last= "last_3",
                        Email="email_3@neiu.edu",
                        Phone="1234567898"
                    },
                    Id= 3,
                    Title ="Swimming pool",
                    Price = "90.0",
                    Description = "Swimming pool, looking for good deal",
                    Condition = "Used"
                },
  
                new Ad(){
                    User = new User()
                    {
                        Id=4,
                        First= "first_4",
                        Last= "last_4",
                        Email="email_4@neiu.edu",
                        Phone="1234567898"
                    },
                    Id= 4,
                    Title ="Dron for sell",
                    Price = "520.0",
                    Description = "This is a brand new Dron for sell, looking for good deal",
                    Condition = "New"
                },
               new Ad(){
                    User = new User()
                    {
                        Id=5,
                        First= "first_5",
                        Last= "last_5",
                        Email="email_5@neiu.edu",
                        Phone="1234567898"
                    },
                    Id= 5,
                    Title ="Samsung for sell",
                    Price = "110.0",
                    Description = "New Samsung for sell",
                    Condition = "New"
                },
               new Ad(){
                    User = new User()
                    {
                        Id=6,
                        First= "first_6",
                        Last= "last_6",
                        Email="email_6@neiu.edu",
                        Phone="1234567898"
                    },
                    Id= 6,
                    Title ="football for sell",
                    Price = "50.00",
                    Description = "Used football in a good condition for sell",
                    Condition = "Used"
                },
        };

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
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