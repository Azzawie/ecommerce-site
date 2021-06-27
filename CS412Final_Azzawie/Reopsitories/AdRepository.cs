using CS412Final_Azzawie.DAL;
using CS412Final_Azzawie.Models;
using CS412Final_Azzawie.Reopsitories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS412Final_Azzawie.Reopsitories
{
    public class AdRepository : IAdRepository
    {
        public List<Ad> GetAds()
        {
            return AdDAL.GetAds();
        }
        public List<Ad> GetUserAds()
        {
            return AdDAL.GetUserAds();
        }
    }
}