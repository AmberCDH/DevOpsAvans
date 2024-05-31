using AvansDevOpsApplication.Domain.Factory;

namespace AvansDevOpsApplication.Domain.FactoryReport
{
    public class PngReportCreator : IReportCreator
    {
        public void exportReport(string header, string footer, List<User> teamInSprint)
        {
            Console.WriteLine("Png");
            //throw new NotImplementedException();
        }
    }
}
