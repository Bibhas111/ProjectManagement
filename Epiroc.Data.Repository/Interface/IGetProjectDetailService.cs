using Epiroc.Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Epiroc.Data.Repository.Interface
{
   public interface IGetProjectDetailService
    {

        List<ProjectDetail> GetAll();

        public int AddProject(ProjectDetail b);

        //public ProjectDetail Get(int id);
        //public int DeleteProject(int id);
        //public int UpdateProject(int id, ProjectDetail b);


    }
}
