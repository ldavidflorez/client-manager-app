using Microsoft.EntityFrameworkCore;
using MyWebApi.Models;
using MyWebApi.Repository;
using MyWebApi.Services;

namespace MyWebApi.Tests
{
    [TestFixture]
    public class ClientServiceIntegrationTests
    {
        private DbContextOptions<ClientContext> _options;
        private ClientContext _context;
        private ClientService _clientService;

        [SetUp]
        public void Setup()
        {
            // PostgreSQL connection string
            var connectionString = "Host=localhost;Port=5432;Database=clientsdb;Username=myuser;Password=mypassword;";

            // Configure options to use PostgreSQL
            _options = new DbContextOptionsBuilder<ClientContext>()
                .UseNpgsql(connectionString)
                .Options;

            // Initialize the database with some test data
            SeedTestData();

            // Create a new instance of the context
            _context = new ClientContext(_options);

            // Create a new instance of the service
            _clientService = new ClientService(new ClientRepository(_context));
        }

        [TearDown]
        public void TearDown()
        {
            // Dispose the context after each test
            _context.Dispose();
        }

        [Test]
        public async Task GetAll_ReturnsAllClients()
        {
            // Act
            var result = await _clientService.GetAll();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(5, result.Count()); // Assuming we have 2 clients in the test data
        }

        [Test]
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

        // Add more test methods for other service methods (Add, Update, Delete, etc.)

        private void SeedTestData()
        {
            using (var context = new ClientContext(_options))
            {
                // Read the contents of the SQL script file
                string filePath = "/home/luisf/Desktop/ClientManagerApp/Backend/MyWebApi.Test/Resources/init.sql";
                string sqlScript = File.ReadAllText(filePath);

                // Execute the SQL script
                context.Database.ExecuteSqlRaw(sqlScript);
            }
        }
    }
}
