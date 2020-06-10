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
    public class ListTodoController : ControllerBase
    {
        private IListTodoService _listTodoService;

        public ListTodoController(IListTodoService listTodoService)
        {
            _listTodoService = listTodoService;
        }

        [HttpGet]
        [Route("api/listtodo/getlisttodo/{todoid}")]
        public IEnumerable<ListTodoRes> GetListTodo(int TodoId)
        {
            return _listTodoService.GetListTodo(TodoId);
        }

        [HttpGet]
        [Route("api/listtodo/getlisttobyid/{Idl}")]
        public ListTodoRes GetListTodoByIDL(int Idl)
        {
            return _listTodoService.GetListTodoByIDL(Idl);
        }

        [HttpPost]
        [Route("api/listtodo/createlisttodo")]
        public int CreateListTodo([FromBody] CreateListTodo request)
        {
            return _listTodoService.CreateListTodo(request);
        }

        [HttpPut]
        [Route("api/listtodo/updatetodo")]
        public int UpdateTodo([FromBody] UpdateListTodo request)
        {
            return _listTodoService.UpdateListTodo(request);
        }

        [HttpDelete]
        [Route("api/listtodo/deletelisttodo/{id}")]
        public bool DeleteListTodo(int Id)
        {
            return _listTodoService.DeleteListTodo(Id);
        }

        [HttpDelete]
        [Route("api/listtodo/finishlisttodo/{id}")]
        public bool FinishListTodo(int Id)
        {
            return _listTodoService.FinishListTodo(Id);
        }
    }
}
