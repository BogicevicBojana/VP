using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class Task
    {
        public int Id { get; set; }
        public DateTime DateIssued { get; set; }
        public DateTime DueDate { get; set; }
        public string Title { get; set; }
        public bool IsCompleted { get; set; }
        public string Description { get; set; }
        public double HoursSpent { get; set; }
        public int ProjectManagerId { get; set; }
        public int TeamMemberId { get; set; }
    }
}
