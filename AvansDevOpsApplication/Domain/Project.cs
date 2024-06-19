namespace AvansDevOpsApplication.Domain
{
    public class Project
    {
        private Guid Id;
        private string Description;
        private ProjectBacklog ProjectBacklog;

        public Project(string description)
        {
            Id = Guid.NewGuid();
            Description = description;
            ProjectBacklog = new ProjectBacklog(Guid.NewGuid());
        }

        public ProjectBacklog GetProjectBacklog()
        {
            return ProjectBacklog;
        }
    }
}
