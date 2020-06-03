using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Todo.Web.Models;
using Todo.Web.Models.Todo;

namespace Todo.Web.Controllers
{
    public class HomeController : Controller
    {

        //public IActionResult Index()
        //{
        //    ViewBag.Message = "Welcome to my demo!";
        //    dynamic mymodel = new ExpandoObject();
        //    mymodel.Teachers = GetTeachers();
        //    mymodel.Students = GetStudents();
        //    return View(mymodel);
        //}

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
        //public class Teacher
        //{
        //    public int TeacherId { get; set; }
        //    public string Code { get; set; }
        //    public string Name { get; set; }
        //}

        //public class Student
        //{
        //    public int StudentId { get; set; }
        //    public string Code { get; set; }
        //    public string Name { get; set; }
        //    public string EnrollmentNo { get; set; }
        //}

        //private List<Teacher> GetTeachers()
        //{
        //    List<Teacher> teachers = new List<Teacher>();
        //    teachers.Add(new Teacher { TeacherId = 1, Code = "TT", Name = "Tejas Trivedi" });
        //    teachers.Add(new Teacher { TeacherId = 2, Code = "JT", Name = "Jignesh Trivedi" });
        //    teachers.Add(new Teacher { TeacherId = 3, Code = "RT", Name = "Rakesh Trivedi" });
        //    return teachers;
        //}

        //public List<Student> GetStudents()
        //{
        //    List<Student> students = new List<Student>();
        //    students.Add(new Student { StudentId = 1, Code = "L0001", Name = "Amit Gupta", EnrollmentNo = "201404150001" });
        //    students.Add(new Student { StudentId = 2, Code = "L0002", Name = "Chetan Gujjar", EnrollmentNo = "201404150002" });
        //    students.Add(new Student { StudentId = 3, Code = "L0003", Name = "Bhavin Patel", EnrollmentNo = "201404150003" });
        //    return students;
        //}
    }
}


