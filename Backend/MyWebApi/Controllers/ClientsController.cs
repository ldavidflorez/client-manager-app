using Microsoft.AspNetCore.Mvc;
using MyWebApi.Models;
using MyWebApi.Repository;
using MyWebApi.Services;

namespace MyWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientsController : ControllerBase
    {
        private ICommonService<Client, Client, Client> _clientService;

        public ClientsController(ICommonService<Client, Client, Client> clientService)
        {
            _clientService = clientService;
        }

        // GET: api/clients
        [HttpGet]
        public async Task<IEnumerable<Client>> Get()
        {
            var result = await _clientService.GetAll();
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