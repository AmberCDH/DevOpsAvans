namespace AvansDevOpsApplication.Domain.Factory
{
    public interface Export
    {
        public void exportReport(string header, string footer, List<User> teamInSprint);
    }
}
