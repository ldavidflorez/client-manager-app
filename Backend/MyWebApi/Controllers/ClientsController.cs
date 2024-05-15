using Microsoft.AspNetCore.Mvc;
using MyWebApi.Models;
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
        public async Task<ActionResult<IEnumerable<Client>>> Get()
        {
            var result = await _clientService.GetAll();
            return Ok(result);
        }

        // GET: api/clients/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Client>> GetById(int id)
        {
            var client = await _clientService.GetById(id);
            return client == null ? NotFound() : Ok(client);
        }

        // POST: api/clients
        [HttpPost]
        public async Task<ActionResult<Client>> Post([FromBody] Client newClient)
        {
            var client = await _clientService.Add(newClient);
            return CreatedAtAction(nameof(GetById), new { id = client.Id }, client);
        }

        // PUT: api/clients/5
        [HttpPut("{id}")]
        public async Task<ActionResult<Client>> Put(int id, [FromBody] Client oldClient)
        {
            var client = await _clientService.Update(id, oldClient);

            return client == null ? NotFound() : Ok(client);
        }

        // DELETE: api/clients/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Client>> Delete(int id)
        {
            var client = await _clientService.Delete(id);
            return client == null ? NotFound() : Ok(client);
        }
    }
}