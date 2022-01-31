using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Epiroc.Data.Entity.DBSets
{
   

        public class ProjectDetailContext : DbContext
        {
            public ProjectDetailContext(DbContextOptions<ProjectDetailContext> options) : base(options)
            {
            }

            DbSet<ProjectDetail> ProjectDetails { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProjectDetail>().HasData(
                new ProjectDetail() { ProjectId = 1, Department = "Construction", ProjectName = "abc",ProjectCost="250",ProjectHr="10hr" },
                  new ProjectDetail() { ProjectId = 2, Department = "Construction", ProjectName = "abc", ProjectCost = "250", ProjectHr = "10hr" },
                    new ProjectDetail() { ProjectId = 3, Department = "water-Energy", ProjectName = "abc", ProjectCost = "250", ProjectHr = "10hr" }



                );
              
        }
    }





    
}
