using Microsoft.EntityFrameworkCore;
using MyWebApi.Models;

namespace MyWebApi.Repository
{
    public class ClientRepository : ICommonRepository<Client>
    {
        private ClientContext _context;

        public ClientRepository(ClientContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Client>> GetAll()
        {
            var result = await _context.Clients.ToListAsync();
            return result;
        }

        public async Task<Client> GetById(int id)
        {
            var result = await _context.Clients.FindAsync(id);
            return result;
        }

        public async Task Add(Client client)
        {
            await _context.Clients.AddAsync(client);
        }

        public void Update(Client client)
        {
            _context.Clients.Attach(client);
            _context.Clients.Entry(client).State = EntityState.Modified;
        }

        public void Delete(Client client)
        {
            _context.Remove(client);
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}