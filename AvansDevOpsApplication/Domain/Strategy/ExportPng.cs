using AvansDevOpsApplication.Domain.Factory;

namespace AvansDevOpsApplication.Domain.Strategy
{
    public class ExportPng : IExport
    {
        public void exportReport(string header, string footer, List<User> teamInSprint)
        {
            Console.WriteLine("Png");
            //throw new NotImplementedException();
        }
    }
}
