using BLL.Entities;
using BLL.Services.SalesManagerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
//using System.Web.Http.Cors;

namespace PL.Controllers.SalesManagerController
{
    
    public class CustomerController : ApiController
    {
        [Route("api/customers")]
        [HttpGet]
        public HttpResponseMessage GetAll()
        {
            var data = CustomerServices.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
    }
}