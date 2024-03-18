namespace AvansDevOpsApplication.Domain.Composite
{
    public class Forum : ForumComponent
    {
        private List<ForumComponent> children = new List<ForumComponent>();
        private BacklogItem backlogItem;

        public Forum(BacklogItem backlogItem) 
        {
            this.backlogItem = backlogItem;
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
            Console.WriteLine($" >Forum; Backlog item ~ {backlogItem.Name} {backlogItem.TimeOfCreation}");
            foreach (ForumComponent forumComponent in children)
            {
                forumComponent.Print();
            }
        }
    }
}
