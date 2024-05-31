namespace AvansDevOpsApplication.Domain.Factory
{
    public interface IReportCreator
    {
        public void exportReport(string header, string footer, List<User> teamInSprint);
    }
}
