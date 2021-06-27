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
    }
}