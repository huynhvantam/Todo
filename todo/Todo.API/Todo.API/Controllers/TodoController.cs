using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using Todo.BAL.Interface;
using Todo.Domain.Request;
using Todo.Domain.Response;

namespace Todo.API.Controllers
{

    [ApiController]
    public class TodoController : ControllerBase
    {
        private readonly ITodoService _todoService;
        public TodoController(ITodoService todoService)
        {
            _todoService = todoService;
        }

        [HttpGet]
        [Route("api/todo/gettodoallgroup")]
        public IEnumerable<TodoRes> GetTodoAllGroup()
        {
            return _todoService.GetTodoAllGroup();
        }

        [HttpGet]
        [Route("api/todo/getlistfinish")]
        public IEnumerable<TodoRes> GetListFinish()
        {
            return _todoService.GetListFinish();
        }
        [HttpGet]
        [Route("api/todo/finishgroup/{groupidg}")]
        public IEnumerable<TodoRes> FinishGroup(int groupIDG)
        {
            return _todoService.FinishGroup(groupIDG);
        }
        [HttpGet]
        [Route("api/todo/getlistimport")]
        public IEnumerable<TodoRes> GetListImportant()
        {
            return _todoService.GetListImportant();
        }


        [HttpGet]
        [Route("api/todo/important/{groupidg}")]
        public IEnumerable<TodoRes> ImportantGroup(int groupIDG)
        {
            return _todoService.ImportantGroup(groupIDG);
        }

        [HttpGet]
        [Route("api/todo/gettodobygroup/{id}")]
        public IEnumerable<TodoRes> GetTodoListByGroup(int id)
        {
            return _todoService.GetTodoListByGroup(id);
        }


        [HttpGet]
        [Route("api/todo/gettodobyid/{id}")]
        public TodoRes GetTodoById(int id)
        {
            return _todoService.GetTodoById(id);
        }


        [HttpPost]
        [Route("api/todo/createtodo")]
        public int CreateTodo([FromBody] CreateTodoReq request)
        {
            return _todoService.CreateTodo(request);
        }


        [HttpPut]
        [Route("api/todo/importanttodo")]
        public bool ImportantTodo([FromBody] UpdateImportantReq request)
        {
            return _todoService.ImportantTodo(request);
        }

        [HttpPut]
        [Route("api/todo/updatetodo")]
        public int UpdateTodo([FromBody] UpdateTodoReq request)
        {
            return _todoService.UpdateTodo(request);
        }
        [HttpPut]
        [Route("api/todo/finishcheckbox")]
        public bool FinishCheckbox([FromBody] FinishCheckboxReq request)
        {
            return _todoService.FinishCheckbox(request);
        }

        [HttpDelete]
        [Route("api/todo/deletetodo/{id}")]
        public bool DeleteTodo(int id)
        {
            return _todoService.DeleteTodo(id);
        }

        [HttpPut]
        [Route("api/todo/finishtodo/{id}")]
        public bool FinishTodo(int id)
        {
            return _todoService.FinishTodo(id);
        }
        [HttpDelete]
        [Route("api/todo/deletefinish/{id}")]
        public bool DeleteFinish(int id)
        {
            return _todoService.DeleteFinish(id);
        }
        [HttpDelete]
        [Route("api/todo/deleteimportant/{id}")]
        public bool DeleteImportant(int id)
        {
            return _todoService.DeleteImportant(id);
        }
        [HttpPut]
        [Route("api/todo/updateprogress/{id}")]
        public int ProgressEdit(int id)
        {
            return _todoService.ProgressEdit(id);
        }

        [HttpGet]
        [Route("api/todo/searchtask/{task}")]
        public IEnumerable<TodoRes> SearchTask(string task)
        {
            return _todoService.SearchTask(task);
        }


        [HttpGet]
        [Route("api/todo/searchtaskgroup/{groupIDG}/{task}")]
        public IEnumerable<TodoRes> SearchTaskGroup(int groupIDG, string task)
        {
            return _todoService.SearchTaskGroup(groupIDG, task);
        }


    }
}
