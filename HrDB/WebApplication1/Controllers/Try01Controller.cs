using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class Try01Controller : ApiController
    {
        // GET: api/Try01
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Try01/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Try01
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Try01/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Try01/5
        public void Delete(int id)
        {
        }
    }
}
