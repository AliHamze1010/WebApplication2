using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication2.Controllers
{
    public class NumberMachineController : ApiController
    {
        public int Get(int id)
        {
            return id + 10 - 2 / 2 * 7;
        }
    }
}
