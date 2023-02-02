using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication2.Controllers
{
    public class HostingCostController : ApiController
    {
        public class ChargeCalculator
        {
            public string Get(int id)
            {
                int initialFortnights = 1;
                int roundedExtra = 0;
                float tax = 0.13f;
                float charge = 5.5f;

                float numberOfExtraFortnights = id / 14;


                roundedExtra = (int)Math.Floor(numberOfExtraFortnights);

                int totalFortnights = initialFortnights + roundedExtra;

                charge = initialFortnights;
                float hst13 = chargetax;
                float total = charge + hst13;

                return totalFortnights + " fortnights at $5.50/FN = $" + charge + " CAD" + "\nHST 13% = $" + hst13 + " CAD" + "\nTotal = $" + total + " CAD";
            }
        }
    }
}
