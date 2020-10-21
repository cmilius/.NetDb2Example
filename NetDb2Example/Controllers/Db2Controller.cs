using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NetDb2Example.Controllers
{
    public class Db2Controller : ApiController
    {
        // GET: api/Db2
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Db2/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Db2
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Db2/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Db2/5
        public void Delete(int id)
        {
        }
    }
}
