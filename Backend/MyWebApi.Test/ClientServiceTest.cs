using Microsoft.EntityFrameworkCore;
using MyWebApi.Models;
using MyWebApi.Repository;
using MyWebApi.Services;

namespace MyWebApi.Tests
{
    // TODO: test controllers, no services
    [TestFixture]
    public class ClientServiceTest
    {
        private DbContextOptions<ClientContext> _options;
        private ClientContext _context;
        private ClientService _clientService;
        private int _lastInsertedId;

        public ClientServiceTest()
        {
            _lastInsertedId = 0;
        }

        [SetUp]
        public void Setup()
        {
            var connectionString = "Host=localhost;Port=5432;Database=clientsdb;Username=myuser;Password=mypassword;";

            _options = new DbContextOptionsBuilder<ClientContext>()
                .UseNpgsql(connectionString)
                .Options;

            _context = new ClientContext(_options);

            _clientService = new ClientService(new ClientRepository(_context));
        }

        [TearDown]
        public void TearDown()
        {
            _context.Dispose();
        }

        [Test, Order(1)]
        public async Task GetAll_ReturnsAllClients()
        {
            // Act
            var result = await _clientService.GetAll();

            // Assert
            Assert.IsNotNull(result);
            Assert.Greater(result.Count(), 0);
        }

        [Test, Order(2)]
        public async Task GetById_ReturnsClientById()
        {
            // Arrange
            int id = 1;

            // Act
            var result = await _clientService.GetById(id);
        
            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(id, result.Id);
        }

        [Test, Order(3)]
        public async Task Add_Client_Success()
        {
            // Arrange
            var client = new Client
            {
                Name = "Luis",
                Lastname = "Florez",
                AccountNumber = "ACC6036944592",
                Balance = 1500.50m,
                DateOfBirth = new DateTime(1998, 12, 15, 0, 0, 0, DateTimeKind.Utc),
                Address = "123 Elm St, Springfield, IL",
                Phone = "555-1234",
                Email = "john.doe@example.com",
                ClientType = "individual",
                MaritalStatus = "single",
                IdentificationNumber = "ID6036654592",
                Profession = "Software Engineer",
                Gender = "Male",
                Nationality = "Colombian"
            };

            // Act
            var addedClient = await _clientService.Add(client);

            // Assert
            Assert.IsNotNull(addedClient);

            _lastInsertedId = addedClient.Id;
        }

        [Test, Order(4)]
        public async Task Update_Client_Success()
        {
            // Arrange
            var idToUpdate = _lastInsertedId;
            
            var updatedClient = new Client
            {
                Name = "Luis",
                Lastname = "Florez",
                AccountNumber = "ACC6036944592",
                Balance = 1000000.0m,
                DateOfBirth = new DateTime(1998, 12, 15, 0, 0, 0, DateTimeKind.Utc),
                Address = "123 Elm St, Springfield, IL",
                Phone = "555-1234",
                Email = "john.doe@example.com",
                ClientType = "corporate",
                MaritalStatus = "single",
                IdentificationNumber = "ID6036944592",
                Profession = "Software Engineer",
                Gender = "Male",
                Nationality = "Colombian"
            };

            // Act
            var result = await _clientService.Update(idToUpdate, updatedClient);

            // Assert
            Assert.IsNotNull(result);
        }

        [Test]
        public async Task Delete_Client_Success()
        {
            // Arrange
            var idToDelete = _lastInsertedId;

            // Act
            var deletedClient = await _clientService.Delete(idToDelete);

            // Assert
            Assert.IsNotNull(deletedClient);
        }
    }
}
