using AvansDevOpsApplication.Domain;
using AvansDevOpsApplication.Domain.NotificationObserver;
using FluentAssertions;

namespace AvansDevOpsApplication.Tests
{
    public class userTests
    {
        [Fact]
        public void ShouldChangeRoleOfUser()
        {
            //Arrange
            var birthday = new DateTime(2000, 1, 12);
            var notificationService = new EmailObserver();
            var user = new User("Tom", "t@mail.com", birthday, RoleType.DEVELOPER, notificationService);

            //Act
            user.Role = RoleType.LEAD_DEVELOPER;

            //Assert
            user.Role.Should().Be(RoleType.LEAD_DEVELOPER);
        }

        [Fact]
        public void ShouldChangeNameOfUser()
        {
            //Arrange
            var birthday = new DateTime(2000, 1, 12);
            var notificationService = new EmailObserver();
            var user = new User("Tom", "t@mail.com", birthday, RoleType.DEVELOPER, notificationService);

            //Act
            user.Name = "Test";

            //Assert
            user.Name.Should().Be("Test");
            user.Name.Should().NotBe("Tom");
        }
        [Fact]
        public void ShouldChangeMailOfUser()
        {
            //Arrange
            var birthday = new DateTime(2000, 1, 12);
            var notificationService = new EmailObserver();
            var user = new User("Tom", "t@mail.com", birthday, RoleType.DEVELOPER, notificationService);

            //Act
            user.Email = "Test";

            //Assert
            user.Email.Should().Be("Test");
            user.Email.Should().NotBe("t@mail.com");
        }

        [Fact]
        public void ShouldReturnToStringOfUser()
        {
            //Arrange
            var birthday = new DateTime(2000, 1, 12);
            var notificationService = new EmailObserver();
            var user = new User("Tom", "t@mail.com", birthday, RoleType.DEVELOPER, notificationService);

            //Act
            var tostring = user.toString();

            //Assert
            tostring.Should().BeEquivalentTo("User ~ Name; " + user.Name + " ~ Birthday; " + user.Birthday + " ~ Role; " + user.Role);
        }
    }
}
