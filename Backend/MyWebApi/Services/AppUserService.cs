using Microsoft.AspNetCore.Identity;
using MyWebApi.Models;
using MyWebApi.Repository;
using MyWebApi.Utils;

namespace MyWebApi.Services
{
    public class AppUserService : ICommonService<AppUser, AppUser, AppUser>
    {
        private ICommonRepository<AppUser> _userRepository;

        public AppUserService(ICommonRepository<AppUser> userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<IEnumerable<AppUser>> GetAll()
        {
            var clients = await _userRepository.GetAll();
            return clients;
        }

        public async Task<AppUser> GetById(int id)
        {
            var user = await _userRepository.GetById(id);

            if (user == null)
            {
                return null;
            }

            return user;
        }

        public async Task<AppUser> GetByName(string name)
        {
            var user = await _userRepository.GetByName(name);

            if (user == null)
            {
                return null;
            }

            return user;
        }

        public async Task<AppUser> Add(AppUser user)
        {
            user.Password = EncryptionHelper.EncryptString(user.Password);
            await _userRepository.Add(user);
            await _userRepository.Save();

            return user;
        }

        public async Task<AppUser> Update(int id, AppUser user)
        {
            var oldUser = await _userRepository.GetById(id);

            if (oldUser == null)
            {
                return null;
            }

            oldUser.Username = user.Username;
            oldUser.Password = EncryptionHelper.EncryptString(user.Password);
            oldUser.Role = user.Role;

            _userRepository.Update(oldUser);
            await _userRepository.Save();

            return oldUser;
        }

        public async Task<AppUser> Delete(int id)
        {
            var user = await _userRepository.GetById(id);

            if (user == null)
            {
                return null;
            }

            _userRepository.Delete(user);
            await _userRepository.Save();

            return user;
        }
    }
}