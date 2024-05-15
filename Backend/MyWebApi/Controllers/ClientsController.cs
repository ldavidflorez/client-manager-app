using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MyWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientsController : ControllerBase
    {
        // GET: api/clients
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "client1", "client2" };
        }

        // GET: api/clients/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "client" + id;
        }

        // POST: api/clients
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/clients/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/clients/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}