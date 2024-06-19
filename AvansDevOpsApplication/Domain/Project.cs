namespace AvansDevOpsApplication.Domain
{
    public class Project
    {
        private ProjectBacklog ProjectBacklog;
        private Guid id;
        public Project(string description)
        {
            Description = description;
            ProjectBacklog = new ProjectBacklog(Guid.NewGuid());
        }

        public Guid Id { get => id ; init => id = Guid.NewGuid(); }
        public string Description { get; set; }

        public ProjectBacklog GetProjectBacklog()
        {
            return ProjectBacklog;
        }
    }
}
