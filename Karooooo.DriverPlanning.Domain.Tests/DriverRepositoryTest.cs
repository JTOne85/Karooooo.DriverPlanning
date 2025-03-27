using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

using Karooooo.DriverPlanning.Persistence;
using Karooooo.DriverPlanning.Domain.Entities;

using Karooooo.DriverPlanning.Domain.Repositories;

using Moq;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
using Karooooo.Common.Domain.Shared;
using Karooooo.AccessManagement.Domain.Primitives;



namespace Karooooo.DriverPlanning.Domain.Tests
{
    public class DriverRepositoryTest
    {
        private Mock<ApplicationDbContext> _mockContext;
        private Mock<DbSet<Driver>> _mockDbSet;
        private Repository<Driver> _repository;

        private IEnumerable<Driver> _testData { get; set; }

        public DriverRepositoryTest()
        {
            var testData = new List<Driver>            {
                Driver.CreateDriver(1),
                Driver.CreateDriver(2),
                Driver.CreateDriver(3),
            }.AsQueryable();
            _testData = [.. testData];
            _mockDbSet = new Mock<DbSet<Driver>>();

            _mockDbSet.As<IQueryable<Driver>>().Setup(m => m.Provider).Returns(testData.Provider);
            _mockDbSet.As<IQueryable<Driver>>().Setup(m => m.Expression).Returns(testData.Expression);
            _mockDbSet.As<IQueryable<Driver>>().Setup(m => m.ElementType).Returns(testData.ElementType);
            _mockDbSet.As<IQueryable<Driver>>().Setup(m => m.GetEnumerator()).Returns(testData.GetEnumerator());

            _mockDbSet.As<IAsyncEnumerable<Driver>>()
                      .Setup(m => m.GetAsyncEnumerator(It.IsAny<CancellationToken>()))
                      .Returns(new TestAsyncEnumerator<Driver>(testData.GetEnumerator()));

            _mockDbSet.Setup(m => m.FindAsync(It.IsAny<object[]>()))
                      .ReturnsAsync((object[] ids) => testData
                      .FirstOrDefault(e => e.Id == (int)ids[0]));

            _mockContext = new Mock<ApplicationDbContext>();
            _mockContext.Setup(c => c.Set<Driver>())
                        .Returns(_mockDbSet.Object);

            _repository = new Repository<Driver>(_mockContext.Object);
        }



        [Fact]
        public void RepositoryExistsTest()
        {
            // Act
            var repositoryExists = _repository != null;

            // Assert
            Assert.True(repositoryExists);

        }

        [Fact]
        public async Task GetByIdAsync_ReturnsDriverDetails()
        {
            // Arrange
            var drivers = _testData.ToList();

            //Act 
            var result = await _repository.GetByIdAsync(drivers[0].Id);

            //Assert
            Assert.NotNull(result);
            Assert.Equal(drivers[0].Id, result.Id);
            Assert.Equal(drivers[0].Uid, result.Uid);
        }

        [Fact]
        public async Task GetByIdAsync_InvalidId_ReturnsDriverDetails()
        {
            // Arrange
            var drivers = _testData.ToList();
            var invalidId = -1;

            //Act 
            var result = await _repository.GetByIdAsync(invalidId);

            //Assert
            Assert.Null(result);
        }


        [Fact]
        public async Task GetAllDriversAsync_RetunsDrivers()
        {
            // Arrange
            var drivers = _testData.ToList();
            //Act 
            var result = await _repository.GetAllAsync();

            //Assert
            Assert.NotNull(result);
            Assert.Equal(drivers.Count, result.Count());
        }

        [Fact]
        public async Task AddAsync_ShouldCreateNewDriver()
        {
            // Arrange
            var drivers = _testData.ToList();
            var newDriver = Driver.CreateDriver(4);            

            //Act 
            await _repository.AddAsync(newDriver);
            
            //Assert            
            _mockDbSet.Verify(m => m.AddAsync(newDriver, default), Times.Once);
            _mockContext.Verify(m => m.SaveChangesAsync(default), Times.Once);           
        }       
    }
}
