using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
        [Route("api/todo/getlistfinishbygroup/{id}")]
        public IEnumerable<TodoRes> GetListFinishByGroup(int groupid)
        {
            return _todoService.GetListFinishByGroup(groupid);
        }

        [HttpGet]
        [Route("api/todo/getlistimport")]
        public IEnumerable<TodoRes> GetListImportant()
        {
            return _todoService.GetListImportant();
        }

        [HttpGet]
        [Route("api/todo/getlistimportantbygroup/{id}")]
        public IEnumerable<TodoRes> GetListImportantByGroup(int groupid)
        {
            return _todoService.GetListImportantByGroup(groupid);
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
    }
}
