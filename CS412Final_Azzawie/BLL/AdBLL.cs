using CS412Final_Azzawie.BLL.Interfaces;
using CS412Final_Azzawie.Models;
using CS412Final_Azzawie.Reopsitories;
using CS412Final_Azzawie.Reopsitories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS412Final_Azzawie.BLL
{
    public class AdBLL : IAdBLL
    {
        public readonly IAdRepository _adRepository;
        public AdBLL()
        {
            _adRepository = new AdRepository();
        }
        public List<Ad> GetAds()
        {
            return _adRepository.GetAds();
        }
        public List<Ad> GetUserAds(int UserId)
        {
            return _adRepository.GetUserAds(UserId);
        }
        public Ad GetUserAd(int Id)
        {
            return _adRepository.GetUserAd(Id);
        }
        public Ad CreateAd(Ad ad, int userId)
        {
            return _adRepository.CreateAd(ad, userId);
        }
        public Ad UpdateAd(Ad ad)
        {
            return _adRepository.UpdateAd(ad);
        }
        public bool DeleteAd(int adId)
        {
            return _adRepository.DeleteAd(adId);
        }

        public List<Ad> GetAdsByTitle(string partialName)
        {
            return _adRepository.GetAdsByTitle(partialName);
        }
    }
}