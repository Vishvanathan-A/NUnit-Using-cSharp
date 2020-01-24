using Moq;
using NUnit.Framework;
using SampleWebApp_With_NunitTest.Api;
using SampleWebApp_With_NunitTest.Models;
using SampleWebApp_With_NunitTest.Repositories;
using SampleWebApp_With_NunitTest.Services;
using SampleWebApp_With_NunitTest.UnitOfWork;

namespace NUnitTest.Api_Controller.TestFixture
{
    [TestFixture]
    public class UserControlllerTestFixture
    {
        #region Test SetUp

        [SetUp]
        public void Setup()
        {
            _SystemUnderTest = null;
            _mockUnitOfWOrk = null;
        }

        private UserController _SystemUnderTest;
        private UserController SystemUnderTest
        {
            get
            {
                if (_SystemUnderTest == null)
                {
                    _SystemUnderTest = new UserController(
                        new UserService(MockUnitOfWOrk.Object));
                }

                return _SystemUnderTest;
            }
        }

        private Mock<IUnitOfWork> _mockUnitOfWOrk;
        private Mock<IUnitOfWork> MockUnitOfWOrk
        {
            get
            {
                if (_mockUnitOfWOrk == null)
                {
                    _mockUnitOfWOrk = new Mock<IUnitOfWork>();
                }

                return _mockUnitOfWOrk;
            }
        }

        #endregion

        [Test]
        public void Expect_Returns_AllUserDetails()
        {
            // Arrange
            var expectedResult = SampleData.GetAllSource();

            Mock<IRepository<User>> mockUserRepostiory = new Mock<IRepository<User>>();
            mockUserRepostiory.Setup(m => m.GetAll()).Returns(expectedResult);

            MockUnitOfWOrk.Setup(m => m.UserRepository).Returns(mockUserRepostiory.Object);

            // Act
            var result = SystemUnderTest.GetAllUsers();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(expectedResult, result); // For Test Successfull

            //Assert.AreNotEqual(expectedResult, result); // For Test Faild
        }

        [Test]
        public void When_ContainsUserId_Expect_Returns_GetUserDetailsById()
        {
            var expectedResult = SampleData.GetById();

            Mock<IRepository<User>> mock = new Mock<IRepository<User>>();
            mock.Setup(o => o.Get(It.IsAny<User>())).Returns(expectedResult);

            MockUnitOfWOrk.Setup(o => o.UserRepository).Returns(mock.Object);

            var result = SystemUnderTest.GetById(1);

            Assert.IsNotNull(result);
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void When_ContainsNewUserData_Expect_Returns_NewAddedUserDetails()
        {
            var expectedResult = SampleData.Insert();

            Mock<IRepository<User>> mock = new Mock<IRepository<User>>();
            mock.Setup(o => o.Insert(It.IsAny<User>()));

            MockUnitOfWOrk.Setup(o => o.UserRepository).Returns(mock.Object);

            var result = SystemUnderTest.AddUser();

            Assert.IsNotNull(result);
        }
    }
}
