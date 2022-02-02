using Epiroc.Data.Entity;
using Epiroc.Data.Entity.DBSets;
using Epiroc.Data.Repository.Interface;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace TestProjectManagement.MockEntity
{

  

   public class ProjectInfoTst
    {
     

        private readonly Mock<IGetProjectInfoService> _mockContext;
        public ProjectInfoTst()
        {


            _mockContext = new Mock<IGetProjectInfoService>();

          
        }

        [Fact]
      public void GetProjectInfo_ByDept_Test()
        {


            IList<ProjectInfo> _prjDetail = new List<ProjectInfo> {
                new ProjectInfo { Department = "Construction" ,
                    ProjectName="Bibhas_Test",
                    ProjectstartDt=Convert.ToDateTime("11-11-2021"),
                    ProjectEnddt=Convert.ToDateTime("11-11-2021"),
                    ProjectId=1,
                    ProjectStaus="Inprogress"
                  }   };


            _mockContext.Setup(mr => mr.GetAll(
              It.IsAny<string>())).Returns((string dept) => _prjDetail.Where(a => a.Department == dept).ToList<ProjectInfo>());

            var _prjDetails = _mockContext.Object.GetAll("Construction");
            Assert.NotNull(_prjDetails); // Test if null
         
       


        }


     

    }

}

