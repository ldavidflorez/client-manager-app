using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyWebApi.Models;

namespace MyWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientsController : ControllerBase
    {
        private ClientContext _context;

        public ClientsController(ClientContext context)
        {
            _context = context;
        }
        // GET: api/clients
        [HttpGet]
        public async Task<IEnumerable<Client>> Get()
        {
            var result = await _context.Clients.ToListAsync();
            return result;
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