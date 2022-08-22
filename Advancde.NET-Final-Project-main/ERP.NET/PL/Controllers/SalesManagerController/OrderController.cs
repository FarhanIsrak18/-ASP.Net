using BLL.Entities;
using BLL.Services.SalesManagerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PL.Controllers.SalesManagerController
{
    public class OrderController : ApiController
    {
        [Route("api/orders")]
        [HttpGet]
        public HttpResponseMessage GetAll()
        {
            var data = OrderServices.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/order/create")]
        [HttpPost]
        public HttpResponseMessage Create(OrderModel order)
        {
            var data = OrderServices.Create(order);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Route("api/order/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            var data = OrderServices.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
    }
}