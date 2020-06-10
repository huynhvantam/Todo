using System;
using System.Collections.Generic;
using System.Text;
using Todo.Domain.Request;
using Todo.Domain.Response;

namespace Todo.BAL.Interface
{
    public interface IListTodoService
    {
        IList<ListTodoRes> GetListTodo(int TodoId);
        ListTodoRes GetListTodoByIDL(int Idl);
        int CreateListTodo(CreateListTodo request);
        int UpdateListTodo(UpdateListTodo request);
        bool DeleteListTodo(int Id);
        bool FinishListTodo(int Id);
    }
}
