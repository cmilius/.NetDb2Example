using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NetDb2Example.Controllers
{
    public class OdbcController : ApiController
    {
        // GET: api/Odbc
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Odbc/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Odbc
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Odbc/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Odbc/5
        public void Delete(int id)
        {
        }
    }
}
