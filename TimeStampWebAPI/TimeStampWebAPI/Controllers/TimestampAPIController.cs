using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TimeStampWebAPI.Models;

namespace TimeStampWebAPI.Controllers
{
    [RoutePrefix("api/TimeStampAPI")]
    public class TimeStampAPIController : ApiController
    {
        //GET: api/TimeStampAPI/unixTime
        [HttpGet]
        [Route("{unixTime:int}")]
        public string Get(int unixTime)
        {

            DateTime dt = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dt = dt.AddSeconds(unixTime).ToLocalTime();

            TimeStampModel ts = new TimeStampModel(dt);

            return ts.ReturnJson();
        }

        //GET: api/TimeStampAPI/naturalTime
        [HttpGet]
        [Route("{val}")]
        public string Get(string val)
        {
            DateTime dt = new DateTime();

            bool isDateTime = DateTime.TryParse(val, out dt);

            if (isDateTime)
            {
                TimeStampModel ts = new TimeStampModel(dt);

                return ts.ReturnJson();
            }
            else
            {
                return string.Format("{{ \"unix\": null, \"natural\": null }}");
            }
        }
    }
}
