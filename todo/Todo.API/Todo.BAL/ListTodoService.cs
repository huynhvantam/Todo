using System;
using System.Collections.Generic;
using System.Text;
using Todo.BAL.Interface;
using Todo.DAL.Interface;
using Todo.Domain.Request;
using Todo.Domain.Response;

namespace Todo.BAL
{
    public class ListTodoService : IListTodoService
    {
        private IListTodoRepository _listTodoRepository;

        public ListTodoService(IListTodoRepository listTodoRepository)
        {
            _listTodoRepository = listTodoRepository;

        }
        public IList<ListTodoRes> GetListTodo(int TodoId)
        {
            return _listTodoRepository.GetListTodo(TodoId);
        }


        public ListTodoRes GetListTodoByIDL(int Idl)
        {
            return _listTodoRepository.GetListTodoByIDL(Idl);
        }

        public int CreateListTodo(CreateListTodo request)
        {
            return _listTodoRepository.CreateListTodo(request);
        }

        public bool DeleteListTodo(int Id)
        {
            return _listTodoRepository.DeleteListTodo(Id);
        }

        public bool FinishListTodo(int Id)
        {
            return _listTodoRepository.FinishListTodo(Id);
        }




        public int UpdateListTodo(UpdateListTodo request)
        {
            return _listTodoRepository.UpdateListTodo(request);
        }
    }
}
