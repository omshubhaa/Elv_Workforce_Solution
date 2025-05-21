using System.ComponentModel.DataAnnotations;

namespace Elv_Workforce_Solution.Models
{
    public class Job
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Company { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public string JobType { get; set; } // Full-time, Part-time, Remote, etc.
        public int Salary { get; set; }
        public string? EmployerEmail { get; set; } // Add the nullable '?' to make it optional
        public DateTime PostedDate { get; set; }
    }
}
