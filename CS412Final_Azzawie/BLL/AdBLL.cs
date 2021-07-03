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
        public List<Ad> GetUserAds()
        {
            return _adRepository.GetUserAds();
        }
        public Ad GetUserAd(int Id)
        {
            return _adRepository.GetUserAd(Id);
        }
        public Ad CreateAd(Ad ad)
        {
            return _adRepository.CreateAd(ad);
        }
        public Ad UpdateAd(Ad ad)
        {
            return _adRepository.CreateAd(ad);
        }
    }
}