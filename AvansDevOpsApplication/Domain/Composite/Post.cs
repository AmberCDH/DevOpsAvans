namespace AvansDevOpsApplication.Domain.Composite
{
    public class Post : ForumComponent
    {
        private string question;
        private string description;
        private DateTime timestamp;
        private User user;
        private List<ForumComponent> children = new List<ForumComponent>();

        public Post(string question, string description, DateTime timestamp, User user, List<ForumComponent> reactions)
        {
            this.timestamp = timestamp;
            this.user = user;
            this.description = description;
            this.question = question;
            this.children = reactions;
        }

        public override void Add(ForumComponent forumComponent)
        {
            this.children.Add(forumComponent);
        }

        public override void Remove(ForumComponent forumComponent)
        {
            this.children.Remove(forumComponent);
        }

        public override ForumComponent GetChild(int index)
        {
            return children[index];
        }

        public override void Print()
        {
            Console.WriteLine($" Post; {user.Name} {user.Email} ~ {question} - {description} - {timestamp}");
            foreach (ForumComponent forumComponent in children)
            {
                forumComponent.Print();
            }
        }
    }
}
