using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Todo.Web.Models.demo;
using Todo.Web.Models.Todo;

namespace Todo.Web.Controllers
{
    public class TodoController : Controller
    {
        private static int groupIdC = 0;

        public IActionResult Index(int id, string task)
        {
            var todo = new List<TodoView>();
            //var url = $"{Common.Common.ApiUrl}/todo/gettodobygroup/{id}";
            string url = String.Empty;


            if (task == null)

            { url = $"{Common.Common.ApiUrl}/todo/gettodobygroup/{id}"; }

            else
            { url = $"{Common.Common.ApiUrl}/todo/searchtaskgroup/{id}/{task}"; }

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
                todo = JsonConvert.DeserializeObject<List<TodoView>>(responseData);
            }
            groupIdC = id;
            //ViewBag.AllGroup = ListFinishGroup();

            //ViewData["AllGroup"] = ListFinishGroup();
            ViewBag.Groupname = ListGroup().Where(p => p.IDG == id).FirstOrDefault().GroupName;

            return View(todo);
        }
        public IActionResult TodoListAllGroup(string task)
        {
            var groups = new List<TodoView>();
            string url = String.Empty;

            if (task == null)

            { url = $"{Common.Common.ApiUrl}/todo/gettodoallgroup"; }

            else
            { url = $"{Common.Common.ApiUrl}/todo/searchtask/{task}"; }

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
                groups = JsonConvert.DeserializeObject<List<TodoView>>(responseData);
            }

            return View(groups);
        }

        public IActionResult ListImportantAllGroup()
        {
            var groups = new List<TodoView>();
            var url = $"{Common.Common.ApiUrl}/todo/getlistimport";
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
                groups = JsonConvert.DeserializeObject<List<TodoView>>(responseData);
            }
            return View(groups);
        }

        public IActionResult ListFinishGroup()
        {
            var groups = new List<TodoView>();
            var url = $"{Common.Common.ApiUrl}/todo/getlistfinish";
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
                groups = JsonConvert.DeserializeObject<List<TodoView>>(responseData);
            }
            return View(groups);
        }

        private List<GroupItem> ListGroup()
        {
            var groups = new List<GroupItem>();
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
                groups = JsonConvert.DeserializeObject<List<GroupItem>>(responseData);
            }
            return groups;
        }

        public IActionResult CreateTodo()
        {
            ViewBag.VGgroups = ListGroup();
            ViewBag.VGgroupid = groupIdC;
            return View();
        }
        [HttpPost]
        public IActionResult CreateTodo(CreateTodo model)
        {
            int result = 0;
            var url = $"{Common.Common.ApiUrl}/todo/createtodo";
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
                TempData["Done"] = "đã tạo To-do List thành công";
            }
            ModelState.Clear();
            ViewBag.VGgroups = ListGroup();
            ViewBag.VGgroupid = groupIdC;
            return View(new CreateTodo() { });
        }

        public IActionResult UpdateTodo(int id)
        {
            var nhanvien = new UpdateTodo();
            var url = $"{Common.Common.ApiUrl}/todo/gettodobyid/{id}";
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
                nhanvien = JsonConvert.DeserializeObject<UpdateTodo>(responseData);
            }
            ViewBag.VGgroups = ListGroup();
            ViewBag.VGgroupid = groupIdC;
            TempData["Done"] = null;
            TempData["Fail"] = null;

            return View(nhanvien);
        }
        [HttpPost]
        public IActionResult UpdateTodo(UpdateTodo model)
        {
            int editResult = 0;
            //var url = $"{Common.Common.ApiUrl}/phongban/suaphongban";

            //HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            var httpWebRequest = (HttpWebRequest)WebRequest.Create($"{Common.Common.ApiUrl}/todo/updatetodo");
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
                var result = streamReader.ReadToEnd();
                editResult = int.Parse(result);
            }
            ViewBag.VGgroups = ListGroup();
            ViewBag.VGgroupid = groupIdC;
            if (editResult <= 0)
            {
                TempData["Fail"] = "TeamData sửa  KHÔNG thành công";
                return View(model);
            }
            else
            {
                TempData["Done"] = "TeamData-đã sửa thành công";
                ModelState.Clear();
                return View(new UpdateTodo() { GroupIDG = groupIdC });
            }

        }
        public IActionResult DeleteTodoGroup(int id)
        {
            var result = false;
            var url = $"{Common.Common.ApiUrl}/todo/deletetodo/{id}";
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
            return RedirectToAction("Index", "Todo", new { id = groupIdC });

        }

        public IActionResult DeleteTodo(int id)
        {
            var result = false;
            var url = $"{Common.Common.ApiUrl}/todo/deletetodo/{id}";
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

            return RedirectToAction("TodoListAllGroup", "Todo");
        }
        public IActionResult DeleteTodoFinsih(int id)
        {
            var result = false;
            var url = $"{Common.Common.ApiUrl}/todo/deletetodo/{id}";
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

            return RedirectToAction("ListFinishGroup", "Todo");
        }

        public IActionResult FinishTodoGroup(int id)
        {
            var result = false;
            var url = $"{Common.Common.ApiUrl}/todo/deletefinish/{id}";
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
            return RedirectToAction("Index", "Todo", new { id = groupIdC });

        }
        public IActionResult FinishTodo(int id)
        {
            var result = false;
            var url = $"{Common.Common.ApiUrl}/todo/deletefinish/{id}";
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

            return RedirectToAction("TodoListAllGroup", "Todo");

        }
        public IActionResult ImportantTodo(int id)
        {
            var result = false;
            var url = $"{Common.Common.ApiUrl}/todo/deleteimportant/{id}";
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
            //return RedirectToAction("Index", "Todo", new { id = groupIdC });
            return RedirectToAction("TodoListAllGroup", "Todo");
        }

        public IActionResult ImportantTodoGroup(int id)
        {
            var result = false;
            var url = $"{Common.Common.ApiUrl}/todo/deleteimportant/{id}";
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
            return RedirectToAction("Index", "Todo", new { id = groupIdC });
            //return RedirectToAction("TodoListAllGroup", "Todo");
        }

        public IActionResult ImportantTodoImportant(int id)
        {
            var result = false;
            var url = $"{Common.Common.ApiUrl}/todo/deleteimportant/{id}";
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
            //return RedirectToAction("Index", "Todo", new { id = groupIdC });
            return RedirectToAction("ListImportantAllGroup", "Todo");
        }
        public IActionResult ProgressEdit(int id)
        {
            var result = 0;
            var url = $"{Common.Common.ApiUrl}/todo/updateprogress/{id}";
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.Method = "PUT";
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
                result = JsonConvert.DeserializeObject<int>(responseData);
            }
            //return RedirectToAction("Index", "Todo", new { id = groupIdC });
            return RedirectToAction("TodoListAllGroup", "Todo");
        }

        public IActionResult ProgressEditGroup(int id)
        {
            var result = 0;
            var url = $"{Common.Common.ApiUrl}/todo/updateprogress/{id}";
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.Method = "PUT";
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
                result = JsonConvert.DeserializeObject<int>(responseData);
            }
            return RedirectToAction("Index", "Todo", new { id = groupIdC });
            //return RedirectToAction("TodoListAllGroup", "Todo");
        }

    }
}
