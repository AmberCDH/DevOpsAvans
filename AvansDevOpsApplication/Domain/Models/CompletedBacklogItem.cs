namespace AvansDevOpsApplication.Domain.Models
{
    public class CompletedBacklogItem
    {
        public string name { get; set; }
        public DateTime timeCompleted {  get; set; }
        public int effort { get; set; }
    }
}
