using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Todo.Web.Models.demo;
using Todo.Web.Models.Group;

namespace Todo.Web.Controllers
{
    public class GroupController : Controller

    {
        private List<Teacher> GetTeachers()
        {
            List<Teacher> teachers = new List<Teacher>();
            teachers.Add(new Teacher { TeacherId = 1, Code = "TT", Name = "Tejas Trivedi" });
            teachers.Add(new Teacher { TeacherId = 2, Code = "JT", Name = "Jignesh Trivedi" });
            teachers.Add(new Teacher { TeacherId = 3, Code = "RT", Name = "Rakesh Trivedi" });
            return teachers;
        }

        public List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student { StudentId = 1, Code = "L0001", Name = "Amit Gupta", EnrollmentNo = "201404150001" });
            students.Add(new Student { StudentId = 2, Code = "L0002", Name = "Chetan Gujjar", EnrollmentNo = "201404150002" });
            students.Add(new Student { StudentId = 3, Code = "L0003", Name = "Bhavin Patel", EnrollmentNo = "201404150003" });
            return students;
        }
        public IActionResult Index()
        {
            var group = new List<GroupView>();
            var url = $"{Common.Common.ApiUrl}/group/getlistgroup";
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.Method = "GET";
            var response = httpWebRequest.GetResponse();
            {
                string responseData;
                Stream responseStream = response.GetResponseStream();
                try
                {
                    StreamReader streamReader = new StreamReader(responseStream);
                    try
                    {
                        responseData = streamReader.ReadToEnd();
                    }
                    finally
                    {
                        ((IDisposable)streamReader).Dispose();
                    }
                }
                finally
                {

                    ((IDisposable)responseStream).Dispose();
                }
                group = JsonConvert.DeserializeObject<List<GroupView>>(responseData);
            }
            //ViewBag.Create = CreateGroup();
            return View(group);
        }
        public IActionResult CreateGroup()
        {
            //ViewBag.Indexx = Index();
            TempData["Done"] = null;
            return View();
        }


        [HttpPost]
        public IActionResult CreateGroup(CreateGroup model)
        {
            int result = 0;
            var url = $"{Common.Common.ApiUrl}/group/creategroup";
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";
            using (var streamWrite = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                var json = JsonConvert.SerializeObject(model);
                streamWrite.Write(json);
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var resResult = streamReader.ReadToEnd();
                result = int.Parse(resResult);

            }

            if (result > 0)
            {
                TempData["Done"] = "đã tạo Group thành công";
            }
            ModelState.Clear();
            return View(new CreateGroup() { });
        }

        public IActionResult UpdateGroup(int id)
        {
            var group = new UpdateGroup();
            var url = $"{Common.Common.ApiUrl}/group/getlistgroupbyid/{id}";
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.Method = "GET";
            var response = httpWebRequest.GetResponse();

            string responseData;
            Stream responseStream = response.GetResponseStream();
            try
            {
                StreamReader streamReader = new StreamReader(responseStream);
                try
                {
                    responseData = streamReader.ReadToEnd();
                }
                finally
                {
                    ((IDisposable)streamReader).Dispose();
                }
            }
            finally
            {

                ((IDisposable)responseStream).Dispose();
            }
            group = JsonConvert.DeserializeObject<UpdateGroup>(responseData);

            TempData["Done"] = null;
            TempData["Fail"] = null;
            return View(group);
        }



        [HttpPost]
        public IActionResult UpdateGroup(UpdateGroup model)
        {
            int result = 0;
            var url = $"{Common.Common.ApiUrl}/group/updategroup";
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "PUT";
            using (var streamWrite = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                var json = JsonConvert.SerializeObject(model);
                streamWrite.Write(json);
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var resResult = streamReader.ReadToEnd();
                result = int.Parse(resResult);
            }

            if (result > 0)
            {
                TempData["Done"] = "đã cập nhật Group thành công";
                ModelState.Clear();
            }
            else
            {
                TempData["Fail"] = "đã cập nhật Group thành công";
            }

            return View(new UpdateGroup() { });
        }

        public IActionResult DeleteGroup(int id)
        {
            var result = false;
            var url = $"{Common.Common.ApiUrl}/group/deletegroup/{id}";
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.Method = "DELETE";
            var response = httpWebRequest.GetResponse();
            {
                string responseData;
                Stream responseStream = response.GetResponseStream();
                try
                {
                    StreamReader streamReader = new StreamReader(responseStream);
                    try
                    {
                        responseData = streamReader.ReadToEnd();
                    }
                    finally
                    {
                        ((IDisposable)streamReader).Dispose();
                    }
                }
                finally
                {

                    ((IDisposable)responseStream).Dispose();
                }
                result = JsonConvert.DeserializeObject<bool>(responseData);
            }
            return RedirectToAction("Index", "Group");
        }
    }
}