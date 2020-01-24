using Moq;
using NUnit.Framework;
using SampleWebApp_With_NunitTest.Repositories;
using SampleWebApp_With_NunitTest.Models;
using SampleWebApp_With_NunitTest.Services;
using SampleWebApp_With_NunitTest.UnitOfWork;

namespace NUnitTest.Service.TestFixture
{
    [TestFixture]
    public class UserServiceTestFixture
    {
        #region Test SetUp

        [SetUp]
        public void Setup()
        {
            _SystemUnderTest = null;
            _mockUnitOfWOrk = null;
        }

        private UserService _SystemUnderTest;
        private UserService SystemUnderTest
        {
            get
            {
                if (_SystemUnderTest == null)
                {
                    _SystemUnderTest = new UserService(MockUnitOfWOrk.Object);
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

            Mock<IRepository<User>> mock = new Mock<IRepository<User>>();
            mock.Setup(o => o.GetAll()).Returns(expectedResult);

            MockUnitOfWOrk.Setup(o => o.UserRepository).Returns(mock.Object);

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

            var result = SystemUnderTest.Insert(expectedResult);

            Assert.IsNotNull(result);
        }
    }
}
