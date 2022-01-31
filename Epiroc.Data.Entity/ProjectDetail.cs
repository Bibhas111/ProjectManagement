using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Epiroc.Data.Entity
{
    public class ProjectDetail
    {

        [Key]
     
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string Department { get; set; }
        public string ProjectCost { get; set; }

        public string ProjectHr { get; set; }




    }
}
