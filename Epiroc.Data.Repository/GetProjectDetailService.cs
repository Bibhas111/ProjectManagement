using Epiroc.Data.Entity;
using Epiroc.Data.Entity.DBSets;
using Epiroc.Data.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Epiroc.Data.Repository
{


 
    public class GetProjectDetailService : IGetProjectDetailService

    { 
           private ProjectDetailContext _context;

    public GetProjectDetailService(ProjectDetailContext context)
    {
        _context = context;
    }


        public int AddProject(ProjectDetail b)
        {
            int res = 0;

            _context.Set<ProjectDetail>().Add(b);
            _context.SaveChanges();

            return res;
        }




        //public int DeleteProject(int id)
        //{
        //    int res = 0;
        //    var project = _context.Set<ProjectDetail>().FirstOrDefault(b => b.ProjectId == id);
        //    if (project != null)
        //    {
        //        _context.Set<ProjectDetail>().Remove(project);
        //        res = _context.SaveChanges();
        //    }
        //    return res;
        //}

        //public ProjectDetail Get(int id)
        //{
        //    try
        //    {
        //        var project = _context.Set<ProjectDetail>().FirstOrDefault(b => b.ProjectId == id);
        //        return project;
        //    }

        //    catch (Exception)
        //    {
        //        throw;
        //    }

        //}

        public List<ProjectDetail> GetAll()
        {
            List<ProjectDetail> prjList;
            try
            {
                prjList = _context.Set<ProjectDetail>().ToList<ProjectDetail>();
            }
            catch (Exception)
            {
                throw;
            }
            return prjList;
        }

        //public int UpdateProject(int id, ProjectDetail b)
        //{
        //    int res = 0;
        //    var project = _context.Set<ProjectDetail>().Find(id);
        //    if (project != null)
        //    {
        //        project.ProjectName = b.ProjectName;
        //        project.ProjectCost = b.ProjectCost;
        //        project.Department = b.Department;
        //        res = _context.SaveChanges();
        //    }
        //    return res;
        //}




    }
}
