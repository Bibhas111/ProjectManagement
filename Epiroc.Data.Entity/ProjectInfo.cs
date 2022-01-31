using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Epiroc.Data.Entity
{
   public class ProjectInfo
    {
        [Key]

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string Department { get; set; }

        public string  ProjectStaus { get; set; }
        public DateTime ProjectstartDt { get; set; }

        public DateTime ProjectEnddt { get; set; }


        //public ProjectInfo(int ProjectId, string ProjectName, string Department, string ProjectStaus, DateTime ProjectstartDt, DateTime ProjectEnddt)
        //{

        //    this.ProjectId = ProjectId;

        //    this.ProjectName = ProjectName;

        //    this.Department = Department;

        //    this.ProjectStaus = ProjectStaus;

        //    this.ProjectstartDt = ProjectstartDt;

        //    this.ProjectEnddt = ProjectEnddt;





        //}

    }
}
