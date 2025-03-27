using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

using Karooooo.DriverPlanning.Persistence;
using Karooooo.DriverPlanning.Domain.Entities;

using Karooooo.DriverPlanning.Domain.Repositories;

using Moq;



namespace Karooooo.DriverPlanning.Domain.Tests
{
    public class DriverRepositoryTest
    {
        private Mock<ApplicationDbContext> _mockContext;
        private Mock<DbSet<Driver>> _mockDbSet;
        private Repository<Driver> _repository;

        public DriverRepositoryTest()
        {
            _mockDbSet = new Mock<DbSet<Driver>>();
            _mockContext = new Mock<ApplicationDbContext>();
            _mockContext.Setup(c => c.Set<Driver>()).Returns(_mockDbSet.Object);
            _repository = new Repository<Driver>(_mockContext.Object);

        }

        private List<Driver> SetupTestData()
        {
            var testData = new List<Driver>            {
                Driver.CreateDriver(1),
                Driver.CreateDriver(2),
                Driver.CreateDriver(3),
            }.AsQueryable();


            _mockDbSet.As<IQueryable<Driver>>().Setup(m => m.Provider).Returns(testData.Provider);
            _mockDbSet.As<IQueryable<Driver>>().Setup(m => m.Expression).Returns(testData.Expression);
            _mockDbSet.As<IQueryable<Driver>>().Setup(m => m.ElementType).Returns(testData.ElementType);
            _mockDbSet.As<IQueryable<Driver>>().Setup(m => m.GetEnumerator()).Returns(testData.GetEnumerator());
            _mockDbSet.Setup(m => m.FindAsync(It.IsAny<object[]>()))
                 .ReturnsAsync((object[] ids) => testData.FirstOrDefault(e => e.Id == (int)ids[0]));

            return [.. testData];

        }

        [Fact]
        public void RepositoryExistsTest()
        {
            //Arrange

            // Act
            var repositoryExists = _repository != null;

            // Assert
            Assert.True(repositoryExists);

        }

        [Fact]
        public async Task GetByIdAsync_ReturnsDriverDetails()
        {
            // Arrange
            var testData = SetupTestData();

            //Act 
            var result = await _repository.GetByIdAsync(testData[0].Id);

            //Assert
            Assert.NotNull(result);
            Assert.Equal(testData[0].Id, result.Id);
            Assert.Equal(testData[0].Uid, result.Uid);
        }

        [Fact]

    }
}
