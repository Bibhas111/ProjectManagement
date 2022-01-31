using System;
using System.Collections.Generic;
using System.Text;

namespace Epiroc.Data.Entity
{
   public class Project
    {

       
        public string ProjectName { get; set; }
        public string Department { get; set; }
        public string ProjectCost { get; set; }

        public string ProjectHr { get; set; }

         public string ProjectStaus { get; set; }
        public DateTime ProjectstartDt { get; set; }

        public DateTime ProjectEndDt { get; set; }



    }
}
