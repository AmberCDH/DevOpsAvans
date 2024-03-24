using AvansDevOpsApplication.Domain.Factory;

namespace AvansDevOpsApplication.Domain.Strategy
{
    public class ExportPng : Export
    {
        public void exportReport(string header, string footer, List<User> teamInSprint)
        {
            Console.WriteLine("Png");
            //throw new NotImplementedException();
        }
    }
}
