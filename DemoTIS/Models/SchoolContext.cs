using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoTIS.Models
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {

        }
        public DbSet<Teacher> Teacher { get; set; }
        public DbSet<HumanResourcesSpecialist> HumanResourcesSpecialist { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HumanResourcesSpecialist>().HasData(
                    new HumanResourcesSpecialist
                    {
                        Id = 2,
                        MailAdress = "humanr@gmail.com",
                        Password = "123"
                       
                    }
                );
        }
    }
}
