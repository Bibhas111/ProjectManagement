using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Epiroc.Data.Entity.DBSets
{
   public class ProjecInfoContext : DbContext
    {

        public ProjecInfoContext(DbContextOptions<ProjecInfoContext> options) : base(options)
        {
        }

          DbSet<ProjectInfo> ProjectInfos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProjectInfo>().HasData(
                new ProjectInfo() { ProjectStaus = "Inprogress",  ProjectId = 1, Department = "Construction", ProjectEnddt = Convert.ToDateTime("11-11-2022"), ProjectName = "abc", ProjectstartDt = Convert.ToDateTime("11-11-2022")} ,
                new ProjectInfo() { ProjectStaus = "Complete", ProjectId = 2, Department = "Construction", ProjectEnddt = Convert.ToDateTime("11-11-2022"), ProjectName = "abc", ProjectstartDt = Convert.ToDateTime("12-11-2022") },
                new ProjectInfo() { ProjectStaus = "Inprogress", ProjectId = 4, Department = "Mining", ProjectEnddt = Convert.ToDateTime("11-11-2022"), ProjectName = "abc", ProjectstartDt = Convert.ToDateTime("12-11-2022") },
                new ProjectInfo() { ProjectStaus = "Complete", ProjectId = 5, Department = "Mining", ProjectEnddt = Convert.ToDateTime("11-11-2022"), ProjectName = "abc", ProjectstartDt = Convert.ToDateTime("12-11-2022") },
                new ProjectInfo() { ProjectStaus = "Inprogress", ProjectId = 3, Department = "water-Energy", ProjectEnddt = Convert.ToDateTime("11-11-2022"), ProjectName = "abc", ProjectstartDt = Convert.ToDateTime("12-11-2022")});

        }
    }
}
