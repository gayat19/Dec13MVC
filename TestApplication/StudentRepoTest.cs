using AppFromStart.Models;
using AppFromStart.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using System.Linq;

namespace TestApplication
{
    [TestClass]
    public class StudentRepoTest
    {
        [TestMethod]
        public void AddMethodTest()
        {
            //arrange
  
            List<Student> students = new List<Student>
            {
                new Student(){Id=101,Name="Tim"}
            };
            var dbSetMock = new Mock<DbSet<Student>>();
            var queriableStudents = students.AsQueryable();
            dbSetMock.As<IQueryable<Student>>().Setup(stu => stu.Provider).Returns(queriableStudents.Provider);
            dbSetMock.As<IQueryable<Student>>().Setup(stu => stu.Expression).Returns(queriableStudents.Expression);
            dbSetMock.As<IQueryable<Student>>().Setup(stu => stu.ElementType).Returns(queriableStudents.ElementType);
            var moqContext = new Mock<SchoolContext>();
            moqContext.Setup(ctx => ctx.Students).Returns(dbSetMock.Object);
            
            IRepo<Student> repo = new StudentRepoEF(moqContext.Object);
            //act
            var res = repo.Get(101);
            //assert
            Assert.AreEqual(101, res.Id);
        }
    }
}
