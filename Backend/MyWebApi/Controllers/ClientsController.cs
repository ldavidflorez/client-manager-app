using Microsoft.AspNetCore.Authorization;
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

        // GET: api/clients (obtain all clients registered)
        [HttpGet]
        [Authorize(Roles = "admin, consultant")]
        public async Task<ActionResult<IEnumerable<Client>>> Get()
        {
            var result = await _clientService.GetAll();
            return Ok(result);
        }

        // GET: api/clients/5 (obtain client by id)
        [HttpGet("{id}")]
        [Authorize(Roles = "admin, consultant")]
        public async Task<ActionResult<Client>> GetById(int id)
        {
            var client = await _clientService.GetById(id);
            return client == null ? NotFound() : Ok(client);
        }

        // POST: api/clients (create new client in DB)
        [HttpPost]
        [Authorize(Roles = "admin, consultant")]
        public async Task<ActionResult<Client>> Post([FromBody] Client newClient)
        {
            // TODO: add scheme validation to newClient
            var client = await _clientService.Add(newClient);
            return CreatedAtAction(nameof(GetById), new { id = client.Id }, client);
        }

        // PUT: api/clients/5 (update a existing client)
        [HttpPut("{id}")]
        [Authorize(Roles = "admin, consultant")]
        public async Task<ActionResult<Client>> Put(int id, [FromBody] Client oldClient)
        {
            // TODO: add scheme validation to oldClient
            var client = await _clientService.Update(id, oldClient);
            return client == null ? NotFound() : Ok(client);
        }

        // DELETE: api/clients/5 (delete existing client)
        [HttpDelete("{id}")]
        [Authorize(Roles = "admin")]
        public async Task<ActionResult<Client>> Delete(int id)
        {
            var user = HttpContext.User;

            if (!user.IsInRole("admin"))
            {
                return StatusCode(403);
            }

            var client = await _clientService.Delete(id);
            return client == null ? NotFound() : Ok(client);
        }
    }
}