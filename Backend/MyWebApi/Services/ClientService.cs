using MyWebApi.Models;
using MyWebApi.Repository;

namespace MyWebApi.Services
{
    public class ClientService : ICommonService<Client, Client, Client>
    {
        private ICommonRepository<Client> _clientRepository;

        public ClientService(ICommonRepository<Client> clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public async Task<IEnumerable<Client>> GetAll()
        {
            var clients = await _clientRepository.GetAll();
            return clients;
        }

        public async Task<Client> GetById(int id)
        {
            var client = await _clientRepository.GetById(id);

            if (client == null)
            {
                return null;
            }

            return client;
        }

        public async Task<Client> GetByName(string name)
        {
            var client = await _clientRepository.GetByName(name);

            if (client == null)
            {
                return null;
            }

            return client;
        }

        public async Task<Client> Add(Client client)
        {
            await _clientRepository.Add(client);
            await _clientRepository.Save();

            return client;
        }

        public async Task<Client> Update(int id, Client client)
        {
            var oldClient = await _clientRepository.GetById(id);

            if (oldClient == null)
            {
                return null;
            }

            oldClient.Name = client.Name;
            oldClient.Lastname = client.Lastname;
            oldClient.AccountNumber = client.AccountNumber;
            oldClient.Balance = client.Balance;
            oldClient.DateOfBirth = client.DateOfBirth;
            oldClient.Address = client.Address;
            oldClient.Phone = client.Phone;
            oldClient.Email = client.Email;
            oldClient.ClientType = client.ClientType;
            oldClient.MaritalStatus = client.MaritalStatus;
            oldClient.IdentificationNumber = client.IdentificationNumber;
            oldClient.Profession = client.Profession;
            oldClient.Gender = client.Gender;
            oldClient.Nationality = client.Nationality;

            _clientRepository.Update(oldClient);
            await _clientRepository.Save();

            return oldClient;
        }

        public async Task<Client> Delete(int id)
        {
            var client = await _clientRepository.GetById(id);

            if (client == null)
            {
                return null;
            }

            _clientRepository.Delete(client);
            await _clientRepository.Save();

            return client;
        }
    }
}