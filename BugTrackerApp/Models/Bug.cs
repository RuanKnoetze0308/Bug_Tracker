using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTrackerApp.Models
{
    public class Bug
    {
        public int Id { get; set; }
        public string BugName { get; set; }
        public string BugDescription { get; set; }
        public string BugCreatedBy { get; set; }
        public string BugAssignedTo { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
    }
}
