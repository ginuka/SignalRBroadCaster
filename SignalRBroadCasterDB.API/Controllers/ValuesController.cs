using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using SignalRBroadCasterDB.HubLib;

namespace SignalRBroadCasterDB.API.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            //ServiceStatusHub.GetStatus("Please check status of the LDAP!");
            ServiceStatusHub.GetStatus("anik", "Please check status of the LDAP!");
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            ServiceStatusHub.GetStatus("consoleApp", "Please check status of the LDAP!");
            return "value";
        }

        // POST api/values
        public void Post()
        {
            var content = new MultipartFormDataContent();
            var httpRequest = HttpContext.Current.Request;

            string _pid = httpRequest.Params["conId"];

            ServiceStatusHub.GetStatus(_pid, "Please check status of the LDAP!");
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }


    }
}
