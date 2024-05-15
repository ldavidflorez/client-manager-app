using Microsoft.EntityFrameworkCore;
using MyWebApi.Models;

namespace MyWebApi.Repository
{
    public class AppUserRepository : ICommonRepository<AppUser>
    {
        private ClientContext _context;

        public AppUserRepository(ClientContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<AppUser>> GetAll()
        {
            var result = await _context.AppUsers.ToListAsync();
            return result;
        }

        public async Task<AppUser> GetById(int id)
        {
            var result = await _context.AppUsers.FindAsync(id);
            return result;
        }

        public async Task<AppUser> GetByName(string name)
        {
            var result = await _context.AppUsers.FirstOrDefaultAsync(u => u.Username == name);
            return result;
        }

        public async Task Add(AppUser user)
        {
            await _context.AppUsers.AddAsync(user);
        }

        public void Update(AppUser user)
        {
            _context.AppUsers.Attach(user);
            _context.AppUsers.Entry(user).State = EntityState.Modified;
        }

        public void Delete(AppUser user)
        {
            _context.Remove(user);
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}