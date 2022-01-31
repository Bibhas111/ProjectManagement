using Epiroc.Data.Entity;
using Epiroc.Data.Entity.DBSets;
using Epiroc.Data.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Epiroc.Data.Repository
{
   public class GetProjectInfoService: IGetProjectInfoService
    {

        private ProjecInfoContext _context;
        public GetProjectInfoService(ProjecInfoContext context)
        {
            _context = context;
        }
        public List<ProjectInfo> GetAll(string projecttype)
        {
            List<ProjectInfo> prjList;
            try
            {
                prjList = _context.Set<ProjectInfo>().ToList<ProjectInfo>().Where(a=>a.Department== projecttype).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            return prjList;
        }

        public ProjectInfo Get(int id)
        {
            try
            {
                var project = _context.Set<ProjectInfo>().FirstOrDefault(b => b.ProjectId == id);
                 return project;
            }

            catch (Exception)
            {
                throw;
            }

           
        }

        public int DeleteProject(int id)
        {
            int res = 0;
            var project = _context.Set<ProjectInfo>().FirstOrDefault(b => b.ProjectId == id);
            if (project != null)
            {
                _context.Set<ProjectInfo>().Remove(project);
                res = _context.SaveChanges();
            }
            return res;
        }

        public int UpdateProject(int id, ProjectInfo b)
        {
            int res = 0;
            var project = _context.Set<ProjectInfo>().Find(id);
            if (project != null)
            {
                project.ProjectName = b.ProjectName;
                project.ProjectstartDt = b.ProjectstartDt;
                project.Department = b.Department;
                res = _context.SaveChanges();
            }
            return res;
        }


        public int AddProject(ProjectInfo b)
        {
            int res = 0;
       
                _context.Set<ProjectInfo>().Add(b);
                _context.SaveChanges();

            return res;
        }


        public List<ProjectInfo> GetConstructionDepartment(string id)
        {
            List<ProjectInfo> prjList;
            try
            {
                prjList = _context.Set<ProjectInfo>().ToList<ProjectInfo>().Where(a=>a.Department==id).ToList();
           
            }

            catch (Exception)
            {
                throw;
            }

            return prjList;
        }

    }
}