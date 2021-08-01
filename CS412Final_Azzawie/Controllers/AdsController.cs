using CS412Final_Azzawie.BLL;
using CS412Final_Azzawie.BLL.Interfaces;
using CS412Final_Azzawie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CS412Final_Azzawie.Controllers
{
    [RoutePrefix("api/ads")]

    public class AdsController : ApiController
    {
        private readonly IAdBLL _adBLL;

        public AdsController()
        {
            _adBLL = new AdBLL();

        }

        [HttpGet]
        public List<Ad> GetAds()
        {
            return _adBLL.GetAds();
        }

        [HttpGet]
        [Route("{id}")]
        public HttpResponseMessage GetUserAd(long id)
        {
            Ad ad = _adBLL.GetUserAd((int)id);
            if (ad == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, "Ad doesn't exist");
            }
            return Request.CreateResponse(HttpStatusCode.OK, ad);
        }

        [HttpPost]
        public HttpResponseMessage CreateOrder(AdRequest adRequest)
        {
            if (adRequest.Ad == null)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Ad is required");
            }

            if (adRequest.UserId == null)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "User id is required");
            }

            Ad order = _adBLL.CreateAd(adRequest.Ad, adRequest.UserId);
            return Request.CreateResponse(HttpStatusCode.OK, order);
        }


        [HttpPut]
        public HttpResponseMessage ModifyOrder(AdRequest adRequest)
        {
            if (adRequest.Ad == null)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Ad is required");
            }

            Ad ad = _adBLL.UpdateAd(adRequest.Ad);

            if (ad == null)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, "There was an issue updating your ad");
            }

            return Request.CreateResponse(HttpStatusCode.OK, ad);
        }



        [HttpDelete]
        [Route("{id}")]
        public HttpResponseMessage DeleteOrder(long id)
        {
            Request.Headers.TryGetValues("APIKey", out var apiKey);
            if (apiKey == null || apiKey.FirstOrDefault() != "1234")
            {
                return Request.CreateResponse(HttpStatusCode.Forbidden, "Please provide the correct api key");
            }

            Ad ad = _adBLL.GetUserAd((int)id);
            if (ad == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, "Ad doesn't exist");
            }
           
           bool adDeleted = _adBLL.DeleteAd((int)id);
            if (adDeleted == false)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, "There was an issue deleting your ad");
            }
            return Request.CreateResponse(HttpStatusCode.OK, $"Ad with id= {id} has been deleted successfully");
        }
    }
}