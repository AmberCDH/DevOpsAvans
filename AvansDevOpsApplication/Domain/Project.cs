namespace AvansDevOpsApplication.Domain
{
    public class Project
    {
        private Guid id;
        private string description;
        private ProjectBacklog ProjectBacklog;

        public Project(string description)
        {
            this.id = Guid.NewGuid();
            this.description = description;
            ProjectBacklog = new ProjectBacklog(Guid.NewGuid());
        }

        public Guid Id { get => Id; set => Id = value; }
        public string Description { get => Description; set => Description = value; }

        public ProjectBacklog GetProjectBacklog()
        {
            return ProjectBacklog;
        }
    }
}
