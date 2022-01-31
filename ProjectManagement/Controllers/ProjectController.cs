using Epiroc.Data.Entity;
using Epiroc.Data.Repository.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectManagement.Controllers
{

   
    [ApiController]
    [Route("api/Project")]
    public class ProjectController : ControllerBase
    {
        private readonly ILogger<ProjectController> _logger;
        IGetProjectInfoService  _projectService;
        IGetProjectDetailService  _projectInfoService;
        public ProjectController(IGetProjectInfoService projectService, IGetProjectDetailService projectInfoService, ILogger<ProjectController> logger)
        {
            _projectService = projectService;
            _projectInfoService = projectInfoService;
            _logger = logger;
        }

        [ProjectManagementErrorHanling]
        [Route("GetAll")]
          [System.Web.Http.HttpGet]
        public IActionResult GetAllProjects(string projecttype)
        {
            try
            {
                _logger.LogInformation("GetAll method called!!!");
                var projects = _projectService.GetAll(projecttype);
                if (projects == null) return NotFound();
                return Ok(projects);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [ProjectManagementErrorHanling]
        [Route("PostProject")]
        [System.Web.Http.HttpPost]
        public IActionResult PostProjectDetail([FromBody] Project prj)
        {


            _logger.LogInformation("PostProject method called!!!");
            ProjectDetail _prjDetail = new ProjectDetail
            {
              
                ProjectName = prj.ProjectName,
                Department = prj.Department,
                ProjectCost = prj.ProjectCost,
                ProjectHr = prj.ProjectHr
            };


            ProjectInfo _prjinfo = new ProjectInfo {
         


                ProjectName = prj.ProjectName,
                ProjectEnddt = prj.ProjectEndDt,
                ProjectstartDt =prj.ProjectstartDt,
                ProjectStaus = prj.ProjectStaus,
                Department =prj.Department
             };

            _projectService.AddProject(_prjinfo);

            _projectInfoService.AddProject(_prjDetail);
//
            int _success = 0;



            return Ok(_success);



        }

        [Route("Getreport")]
        [System.Web.Http.HttpGet]
        public IActionResult GetProjectDetail(string Department)


        {  _logger.LogInformation("Getreport method called!!!");
            ProjectReport rpr = new ProjectReport();
            int _success=0;
            int _inpreogress = 0;
           try {
                _success = _projectService.GetConstructionDepartment(Department).Where(a=>a.ProjectStaus=="Complete").Count();
                _inpreogress = _projectService.GetConstructionDepartment(Department).Where(a => a.ProjectStaus == "Inprogress").Count();

                rpr.Completed = _success;
                rpr.Inprogress = _inpreogress;

                  return Ok(rpr);

            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
