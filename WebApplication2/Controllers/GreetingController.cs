using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication2.Controllers
{
    public class GreetingController : ApiController
    {
        public string Post()
        {
            return "Hello world!";
        }

        public string Get(int id)
        {
            return "Greeting to " + id + " people";
        }
    }
}
