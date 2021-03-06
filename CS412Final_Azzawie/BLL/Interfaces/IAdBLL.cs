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
        List<Ad> GetUserAds(int UserId);
        Ad GetUserAd(int Id);
        Ad CreateAd(Ad ad, int userId);
        Ad UpdateAd(Ad ad);
        bool DeleteAd(int adId);
        List<Ad> GetAdsByTitle(string partialName);
    }
}