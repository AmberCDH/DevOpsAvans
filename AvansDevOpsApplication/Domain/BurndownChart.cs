using AvansDevOpsApplication.Domain.Models;
using AvansDevOpsApplication.Domain.StrategySprint;

namespace AvansDevOpsApplication.Domain
{
    public class BurndownChart
    {
        private static int TotalEffort(List<BacklogItem> items)
        {
            int total = 0;
            foreach (var item in items)
            {
                total += item.Effort;
            }
            return total;
        }

        private static List<CompletedBacklogItem> CompletedItems(List<BacklogItem> items)
        {
            List<CompletedBacklogItem> completedBacklogItems = new List<CompletedBacklogItem>();
            foreach (var item in items)
            {
                if (item.GetState() == item.GetDoneState())
                {
                    CompletedBacklogItem completedItem = new CompletedBacklogItem { timeCompleted = item.TimeCompleted, name = item.Name, effort = item.Effort };
                    completedBacklogItems.Add(completedItem);
                }
            }
            return completedBacklogItems;
        }

        public static void Generate(Sprint sprint)
        {
            Console.WriteLine("Burndown Chart:");

            var total = TotalEffort(sprint.getBacklogItems());
            var completedItems = CompletedItems(sprint.getBacklogItems());

            for (int i = total; i >= 0; i--)
            {
                Console.Write($"{i,2} |");

                foreach (var item in completedItems)
                {
                    if (item.effort >= i)
                        Console.Write("██");
                    else
                        Console.Write("  ");
                }

                Console.WriteLine();
            }
        }
    }
}
