using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Todo.Web.Models.ListTodo;

namespace Todo.Web.Controllers
{
    public class ListTodoController : Controller
    {
        private static int todoList = 0;
        public ActionResult Index(int id)
        {
            var todo = new List<ListTodoView>();
            var url = $"{Common.Common.ApiUrl}/listtodo/getlisttodo/{id}";
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
                todo = JsonConvert.DeserializeObject<List<ListTodoView>>(responseData);
            }
            todoList = id;
            ViewBag.TodoList = TodoList().Where(p => p.ID == id).FirstOrDefault().TaskName;
            ViewBag.GroupList = TodoList().Where(p => p.ID == id).FirstOrDefault().GroupIDG;
            return View(todo);
        }

        private List<TodoItem> TodoList()
        {
            var todos = new List<TodoItem>();
            var url = $"{Common.Common.ApiUrl}/todo/gettodoallgroup";
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
                todos = JsonConvert.DeserializeObject<List<TodoItem>>(responseData);
            }
            return todos;
        }

        public IActionResult CreateListTodo()
        {
            ViewBag.TodoList = TodoList();
            ViewBag.TodoListID = todoList;
            ViewBag.TodoListIDd = TodoList().Where(p => p.ID == todoList).FirstOrDefault().TaskName;
            return View();
        }
        [HttpPost]
        public IActionResult CreateListTodo(CreateListTodo model)
        {
            int result = 0;
            var url = $"{Common.Common.ApiUrl}/listtodo/createlisttodo";
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
                TempData["Done"] = "List create successfully";
            }
            ModelState.Clear();
            ViewBag.TodoList = TodoList();
            ViewBag.TodoListID = todoList;

            return View(new CreateListTodo() { });
        }

        public IActionResult UpdateListTodo(int id)
        {
            var list = new UpdateListTodo();
            var url = $"{Common.Common.ApiUrl}/listtodo/getlisttobyid/{id}";
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
                list = JsonConvert.DeserializeObject<UpdateListTodo>(responseData);
            }
            ViewBag.TodoList = TodoList();
            ViewBag.TodoListID = todoList;
            ViewBag.TodoListIDd = TodoList().Where(p => p.ID == todoList).FirstOrDefault().TaskName;
            TempData["Done"] = null;
            TempData["Fail"] = null;

            return View(list);
        }

        [HttpPost]
        public IActionResult UpdateListTodo(UpdateListTodo model)
        {
            int editResult = 0;
            var httpWebRequest = (HttpWebRequest)WebRequest.Create($"{Common.Common.ApiUrl}/listtodo/updatetodo");
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
            ViewBag.TodoList = TodoList();
            ViewBag.TodoListID = todoList;
            if (editResult <= 0)
            {
                TempData["Fail"] = "List edit fail";
                return View(model);
            }
            else
            {
                TempData["Done"] = "List edit successfully";
                ModelState.Clear();
                return View(new UpdateListTodo() { TodoID = todoList });
            }

        }

        public IActionResult DeleteListTodo(int id)
        {
            var result = false;
            var url = $"{Common.Common.ApiUrl}/listtodo/deletelisttodo/{id}";
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
            return RedirectToAction("Index", "ListTodo", new { id = todoList });
        }

        public IActionResult FinishListTodo(int id)
        {
            var result = false;
            var url = $"{Common.Common.ApiUrl}/listtodo/finishlisttodo/{id}";
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
            return RedirectToAction("Index", "ListTodo", new { id = todoList });
        }
    }
}