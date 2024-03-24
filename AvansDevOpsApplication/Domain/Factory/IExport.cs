namespace AvansDevOpsApplication.Domain.Factory
{
    public interface IExport
    {
        public void exportReport(string header, string footer, List<User> teamInSprint);
    }
}
