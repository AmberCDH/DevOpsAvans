namespace AvansDevOpsApplication.Domain.CompositeForum
{
    public class Post : ForumComponent
    {
        private string question;
        private string description;
        private DateTime timestamp;
        private User user;
        private List<ForumComponent> children = new List<ForumComponent>();

        public Post(string question, string description, DateTime timestamp, User user)
        {
            this.timestamp = timestamp;
            this.user = user;
            this.description = description;
            this.question = question;
        }

        public override void Add(ForumComponent forumComponent)
        {
            this.children.Add(forumComponent);
        }

        public override void Remove(ForumComponent forumComponent)
        {
            this.children.Remove(forumComponent);
        }

        public override ForumComponent GetChild(int i)
        {
            return children[i];
        }

        public override void Print()
        {
            Console.WriteLine($" >Post; {user.Name} {user.Email} ~ {question} - {description} - {timestamp}");
            foreach (ForumComponent forumComponent in children)
            {
                forumComponent.Print();
            }
        }
    }
}
