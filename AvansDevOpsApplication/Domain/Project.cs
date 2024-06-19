namespace AvansDevOpsApplication.Domain
{
    public class Project
    {
        private ProjectBacklog ProjectBacklog;
        public Project(string description)
        {
            Id = Guid.NewGuid();
            Description = description;
            ProjectBacklog = new ProjectBacklog(Guid.NewGuid());
        }

        public Guid Id { get; init; }
        public string Description { get; set; }

        public ProjectBacklog GetProjectBacklog()
        {
            return ProjectBacklog;
        }
    }
}
