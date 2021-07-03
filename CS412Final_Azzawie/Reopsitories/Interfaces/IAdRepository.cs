using CS412Final_Azzawie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS412Final_Azzawie.Reopsitories.Interfaces
{
    public interface IAdRepository
    {
        List<Ad> GetAds();
        List<Ad> GetUserAds();
        Ad GetUserAd();
        Ad CreateAd(Ad ad);
    }
}