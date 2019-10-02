using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using JobAppMS.Models;


namespace JobAppMS.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        public DbSet<PersonalDetail> PersonalDetails { get; set; }
        public DbSet<JobList> JobLists { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Experience> Experience { get; set; }
        public DbSet<Training> Training { get; set; }
        public DbSet<JobApplication> JobApplication { get; set; }
       


    }
}
