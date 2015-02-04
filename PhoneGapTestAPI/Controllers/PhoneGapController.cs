using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PhoneGapTestAPI.Controllers
{
    public class PhoneGapController : ApiController
    {
        // GET: api/PhoneGap/GetTime
        [HttpGet]
        public string GetTime()
        {
            return DateTime.Now.ToLongTimeString();
        }
 
   
    }
}
