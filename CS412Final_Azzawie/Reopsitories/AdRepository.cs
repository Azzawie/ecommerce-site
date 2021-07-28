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

        public List<Ad> GetUserAds(int UserId)
        {
            return AdDAL.GetUserAds(UserId);
        }

        public Ad GetUserAd(int Id)
        {
            return AdDAL.GetUserAd(Id);
        }

        public Ad CreateAd(Ad ad, int userId)
        {
            return AdDAL.CreateAd(ad, userId);
        }

        public Ad UpdateAd(Ad ad)
        {
            return AdDAL.UpdateAd(ad);
        }

        public bool DeleteAd(int adId)
        {
            return AdDAL.DeleteAd(adId);
        }
    }
}