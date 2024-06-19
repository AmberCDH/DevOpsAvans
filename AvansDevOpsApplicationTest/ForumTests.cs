using AvansDevOpsApplication.Domain;
using AvansDevOpsApplication.Domain.CompositeForum;
using AvansDevOpsApplication.Domain.NotificationObserver;
using FluentAssertions;

namespace AvansDevOpsApplication.Tests
{
    public class ForumTests
    {
        [Fact]
        public void ShouldCreateForum()
        {
            //Arrange
            var backlogItem = new BacklogItem("Name", "Backlog for the turtle shop project", null, DateTime.Now);
            var forum = new Forum(backlogItem);

            //Assert
            forum.Should().NotBeNull();
        }

        [Fact]
        public void ShouldAddForumPost()
        {
            //Arrange
            var user = new User("John", "john@example.com", new DateTime(1992, 1, 1), RoleType.DEVELOPER, new EmailObserver());
            var backlogItem = new BacklogItem("Name", "Backlog for the turtle shop project", null, DateTime.Now);
            var forum = new Forum(backlogItem);
            var reactions = new List<ForumComponent>();
            var post = new Post("What is the meaning of life", "I was wondering what is the meaning of life", DateTime.Now, user);

            //Act
            forum.Add(post);

            //Assert
            forum.GetChild(0).Should().BeEquivalentTo(post);
        }

        [Fact]
        public void ShouldAddReactionToForumPost()
        {
            //Arrange
            var user = new User("John", "john@example.com", new DateTime(1992, 1, 1), RoleType.DEVELOPER, new EmailObserver());
            var backlogItem = new BacklogItem("Name", "Backlog for the turtle shop project", null, DateTime.Now);
            var forum = new Forum(backlogItem);
            var reaction = new Reaction("42", DateTime.Now, user);
            var post = new Post("What is the meaning of life", "I was wondering what is the meaning of life", DateTime.Now, user);

            //Act
            forum.Add(post);
            post.Add(reaction);

            //Assert
            forum.GetChild(0).GetChild(0).Should().BeEquivalentTo(reaction);
        }

        [Fact]
        public void ShouldRemoveReactionToForumPost()
        {
            //Arrange
            var user = new User("John", "john@example.com", new DateTime(1992, 1, 1), RoleType.DEVELOPER, new EmailObserver());
            var backlogItem = new BacklogItem("Name", "Backlog for the turtle shop project", null, DateTime.Now);
            var forum = new Forum(backlogItem);
            var reaction = new Reaction("42", DateTime.Now, user);
            var post = new Post("What is the meaning of life", "I was wondering what is the meaning of life", DateTime.Now, user);

            //Act
            forum.Add(post);
            post.Add(reaction);
            post.Remove(reaction);

            //Assert
            Action action = () => forum.GetChild(0).GetChild(0);
            action.Should().Throw<ArgumentOutOfRangeException>();
        }

        [Fact]
        public void ShouldPrint()
        {
            //Arrange
            var user = new User("John", "john@example.com", new DateTime(1992, 1, 1), RoleType.DEVELOPER, new EmailObserver());
            var backlogItem = new BacklogItem("Name", "Backlog for the turtle shop project", null, DateTime.Now);
            var forum = new Forum(backlogItem);
            var reaction = new Reaction("42", DateTime.Now, user);
            var post = new Post("What is the meaning of life", "I was wondering what is the meaning of life", DateTime.Now, user);

            //Act
            forum.Add(post);
            post.Add(reaction);
            forum.Print();

            //Assert
            forum.Should().NotBeNull();
        }
    }
}
