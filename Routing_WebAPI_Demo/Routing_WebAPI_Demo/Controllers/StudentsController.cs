using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Routing_WebAPI_Demo.Models;
namespace Routing_WebAPI_Demo.Controllers
{
    [RoutePrefix("students")]
    public class StudentsController : ApiController
    {
        static List<Student> students = new List<Student>()
    {
           new Student(){Id=1,Name="Ranjitha"},
            new Student(){Id=2,Name="Shilpa"},
             new Student(){Id=3,Name="Pavani"},
            new Student(){Id=4,Name="Shylaja"},
             new Student(){Id=5,Name="Raziq"}
        };

        public List<string> CourseList { get;  set; }
        [HttpGet]
        [Route]
        public IEnumerable<Student> GetAllStudents()
        {
            return students;
        }
        [Route("{StudentId1}/{sid2}")]
        public IEnumerable<Student> GetStudentByIds(int StudentId1, int sid2)
        {
            List<Student> stuList = new List<Student>();         
           stuList.Add(students.FirstOrDefault(s => s.Id == StudentId1));
            stuList.Add( students.FirstOrDefault(s => s.Id == sid2));       
            return stuList;
        }
        [Route("{id}/courses")]
        public IEnumerable<string> GetStudentCourse(int id)
        {
            if (id == 1)
                CourseList = new List<string>() { "Java", "spring", "MVC" };
            else if(id==2)
                CourseList = new List<string>() { "MongoDB", "React", "Angular" };
            else if (id == 3)
                CourseList = new List<string>() { "C#.Net", "MVC", "web API Core" };
            else if (id == 4)
                CourseList = new List<string>() { "python", "Splunk", "Django" };
            else
                CourseList = new List<string>() { "PHP", "MySQL"};
            return CourseList;
        }
        [Route("api/studentinfo/{sid:int?}")]
        public Student GetStudentinfo(int sid=1)
        {
            return students.FirstOrDefault(s => s.Id == sid);
        }
    }
}
