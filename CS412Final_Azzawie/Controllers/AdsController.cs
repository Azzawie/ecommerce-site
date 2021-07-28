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

        public AdsController(IAdBLL orderBLL)
        {
            _adBLL = orderBLL;
        }

        [HttpGet]
        public List<Ad> GetAds()
        {
            return _adBLL.GetAds();
        }

        [HttpGet]
        [Route("{id}")]
        public HttpResponseMessage GetOrder(long id)
        {
            Ad ad = _adBLL.GetUserAd((int)id);
            if (ad == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, "Ad doesn't exist for that id");
            }

            return Request.CreateResponse(HttpStatusCode.OK, ad);
        }

        [HttpGet]
        [Route("customers/names/{partialName}")]
        public HttpResponseMessage GetCustomerNames(string partialName)
        {
            List<string> customerNames = new List<string>();
            List<Order> orders = _orderBLL.GetOrdersByCustomerName(partialName);
            if (orders != null)
                customerNames = orders.Select(x => x.CustomerName).Distinct().ToList();

            return Request.CreateResponse(HttpStatusCode.OK, customerNames);
        }

        [HttpGet]
        [Route("customers/{partialName}")]
        public HttpResponseMessage GetOrdersByCustomerName(string partialName)
        {
            List<Order> orders = _orderBLL.GetOrdersByCustomerName(partialName);
            return Request.CreateResponse(HttpStatusCode.OK, orders);
        }

        [HttpPost]
        [Route("addorder")]
        public HttpResponseMessage CreateOrder(OrderRequest orderRequest)
        {
            if (orderRequest.Order == null)
                return Request.CreateResponse(HttpStatusCode.BadRequest, "You must provide an order");

            if (orderRequest.ServiceIds == null)
                return Request.CreateResponse(HttpStatusCode.BadRequest, "You must provide a service list");

            Order order = _orderBLL.CreateOrder(orderRequest.Order, orderRequest.ServiceIds);

            return Request.CreateResponse(HttpStatusCode.OK, order);
        }

        [HttpPost]
        public HttpResponseMessage CreateOrder2(OrderRequest orderRequest)
        {
            if (orderRequest.Order == null)
                return Request.CreateResponse(HttpStatusCode.BadRequest, "You must provide an order");

            if (orderRequest.ServiceIds == null)
                return Request.CreateResponse(HttpStatusCode.BadRequest, "You must provide a service list");

            Order order = _orderBLL.CreateOrder(orderRequest.Order, orderRequest.ServiceIds);

            return Request.CreateResponse(HttpStatusCode.OK, order);
        }

        [HttpPut]
        public HttpResponseMessage ModifyOrder(OrderRequest orderRequest)
        {
            if (orderRequest.Order == null)
                return Request.CreateResponse(HttpStatusCode.BadRequest, "You must provide an order");

            Order order = _orderBLL.ModifyOrder(orderRequest.Order, orderRequest.ServiceIds);

            if (order == null)
                return Request.CreateResponse(HttpStatusCode.InternalServerError, "There was an issue modifying your order");

            return Request.CreateResponse(HttpStatusCode.OK, order);
        }

        [HttpDelete]
        [Route("{id}")]
        public HttpResponseMessage DeleteOrder(long id)
        {
            Request.Headers.TryGetValues("APIKey", out var apiKey);
            if (apiKey == null || apiKey.FirstOrDefault() != "abcd")
                return Request.CreateResponse(HttpStatusCode.Forbidden, "Please provide the correct api key");

            Order order = _orderBLL.GetOrder(id);
            if (order == null)
                return Request.CreateResponse(HttpStatusCode.NotFound, "The order id provided does not exist");

            bool orderDeleted = _orderBLL.DeleteOrder(id);
            if (orderDeleted == false)
                return Request.CreateResponse(HttpStatusCode.InternalServerError, "There was an issue deleting your order");

            return Request.CreateResponse(HttpStatusCode.OK, order);
        }





















    }
}