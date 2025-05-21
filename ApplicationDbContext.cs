using Elv_Workforce_Solution.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Elv_Workforce_Solution.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Job> Jobs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Job>().HasData(
                new Job
                {
                    Id = 1, 
                    Title = "Software Engineer",
                    Company = "Tech Corp",
                    Location = "Thapathali, Kathmandu",
                    Description = "Develop and maintain web applications.",
                    JobType = "Full-time",
                    Salary = 80000,
                    PostedDate = new DateTime(2025, 02, 01),
                }
                );
        }
    }
}
