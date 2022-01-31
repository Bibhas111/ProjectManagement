using Epiroc.Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Epiroc.Data.Repository.Interface
{
   
    public interface IGetProjectInfoService
    {
        List<ProjectInfo> GetAll(string projecttype);
        public ProjectInfo Get(int id);
        public int DeleteProject(int id);
        public int UpdateProject(int id, ProjectInfo b);

        public List<ProjectInfo> GetConstructionDepartment(string id);

        public int AddProject(ProjectInfo b);
    }


}
