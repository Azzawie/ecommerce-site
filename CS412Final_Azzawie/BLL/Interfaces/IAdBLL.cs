using CS412Final_Azzawie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS412Final_Azzawie.BLL.Interfaces
{
    public interface IAdBLL
    {
        List<Ad> GetAds();
        List<Ad> GetUserAds();
        Ad GetUserAd();
        Ad CreateAd(Ad ad);
        Ad UpdateAd(Ad ad);
    }
}