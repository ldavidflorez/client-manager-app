using Microsoft.AspNetCore.Mvc;
using MyWebApi.Models;
using MyWebApi.Repository;

namespace MyWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientsController : ControllerBase
    {
        private ICommonRepository<Client> _clientRepository;

        public ClientsController(ICommonRepository<Client> clientRepository)
        {
            _clientRepository = clientRepository;
        }

        // GET: api/clients
        [HttpGet]
        public async Task<IEnumerable<Client>> Get()
        {
            var result = await _clientRepository.GetAll();
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