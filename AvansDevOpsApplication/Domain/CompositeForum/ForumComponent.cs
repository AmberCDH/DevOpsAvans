namespace AvansDevOpsApplication.Domain.CompositeForum
{
    // gebruiker kan op een forum dingen posten 
    public abstract class ForumComponent
    {
        public virtual void Add(ForumComponent forumComponent) 
        {
            throw new NotImplementedException();
        }
        public virtual void Remove(ForumComponent forumComponent)
        {
            throw new NotImplementedException();
        }
        public virtual ForumComponent GetChild(int i)
        {
            throw new NotImplementedException();
        }

        public abstract void Print();


    }
}
