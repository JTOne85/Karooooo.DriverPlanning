using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

using Karooooo.DriverPlanning.Persistence;
using Karooooo.DriverPlanning.Domain.Entities;

using Moq;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
using Karooooo.Common.Domain.Shared;
using Karooooo.AccessManagement.Domain.Primitives;
using Karooooo.DriverPlanning.Persistence.Repositories;



namespace Karooooo.DriverPlanning.Domain.Tests
{
    public class DriverRepositoryTest
    {
        private Mock<ApplicationDbContext> _mockContext;
        private Mock<DbSet<DriverCompliance>> _mockDbSet;
        private Repository<DriverCompliance> _repository;

        private IEnumerable<DriverCompliance> _testData { get; set; }

        public DriverRepositoryTest()
        {
            var testData = new List<DriverCompliance>            {
                DriverCompliance.CreateDriver(1),
                DriverCompliance.CreateDriver(2),
                DriverCompliance.CreateDriver(3),
            }.AsQueryable();
            _testData = [.. testData];
            _mockDbSet = new Mock<DbSet<DriverCompliance>>();

            _mockDbSet.As<IQueryable<DriverCompliance>>().Setup(m => m.Provider).Returns(testData.Provider);
            _mockDbSet.As<IQueryable<DriverCompliance>>().Setup(m => m.Expression).Returns(testData.Expression);
            _mockDbSet.As<IQueryable<DriverCompliance>>().Setup(m => m.ElementType).Returns(testData.ElementType);
            _mockDbSet.As<IQueryable<DriverCompliance>>().Setup(m => m.GetEnumerator()).Returns(testData.GetEnumerator());

            _mockDbSet.As<IAsyncEnumerable<DriverCompliance>>()
                      .Setup(m => m.GetAsyncEnumerator(It.IsAny<CancellationToken>()))
                      .Returns(new TestAsyncEnumerator<DriverCompliance>(testData.GetEnumerator()));

            _mockDbSet.Setup(m => m.FindAsync(It.IsAny<object[]>()))
                      .ReturnsAsync((object[] ids) => testData
                      .FirstOrDefault(e => e.Id == (int)ids[0]));

            _mockContext = new Mock<ApplicationDbContext>();
            _mockContext.Setup(c => c.Set<DriverCompliance>())
                        .Returns(_mockDbSet.Object);

            _repository = new Repository<DriverCompliance>(_mockContext.Object);
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
            var newDriver = DriverCompliance.CreateDriver(4);            

            //Act 
            await _repository.AddAsync(newDriver);
            
            //Assert            
            _mockDbSet.Verify(m => m.AddAsync(newDriver, default), Times.Once);
            _mockContext.Verify(m => m.SaveChangesAsync(default), Times.Once);           
        }       

        [Fact]
        public async Task UpdateAsync_ShouldUpdateEntity()
        {
            // Arrange            
            var entity = await _repository.GetByIdAsync(1);

            if (entity != null)
                entity.DriverDetailsId = 1;

            _mockDbSet.Setup(m => m.Update(It.IsAny<DriverCompliance>())).Verifiable();
            _mockContext.Setup(m => m.SaveChangesAsync(default)).ReturnsAsync(1);

            // Act
            await _repository.UpdateAsync(entity);

            // Assert
            _mockDbSet.Verify(m => m.Update(It.Is<DriverCompliance>(e => e == entity)), Times.Once);
            _mockContext.Verify(m => m.SaveChangesAsync(default), Times.Once);
        }

        [Fact]
        public async Task UpdateAsync_InvalidId_ShouldNotUpdateEntity()
        {
            // Arrange            
            var entity = DriverCompliance.CreateDriver(9);
            entity.DriverDetailsId = 1;
            _mockDbSet.Setup(db => db.FindAsync(entity.Id)).ReturnsAsync(null as DriverCompliance);            

            // Act & Assert
            await Assert.ThrowsAsync<InvalidOperationException>(() => _repository.UpdateAsync(entity));           
        }
    }
}
