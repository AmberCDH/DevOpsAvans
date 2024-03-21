using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvansDevOpsApplication.Domain.Models
{
    public class CompletedBacklogItem
    {
        public string name { get; set; }
        public DateTime timeCompleted {  get; set; }
        public int effort { get; set; }
    }
}
