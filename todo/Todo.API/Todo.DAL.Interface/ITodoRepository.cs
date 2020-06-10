using System;
using System.Collections.Generic;
using System.Text;
using Todo.Domain.Request;
using Todo.Domain.Response;

namespace Todo.DAL.Interface
{
    public interface ITodoRepository
    {
        IList<TodoRes> GetTodoListByGroup(int groupid);
        IList<TodoRes> GetTodoAllGroup();
        IList<TodoRes> GetListFinish();
        IList<TodoRes> FinishGroup(int groupIDG);
        IList<TodoRes> SearchTaskGroup(int groupIDG, string Task);
        IList<TodoRes> SearchTask(string Task);
        IList<TodoRes> GetListImportant();
        IList<TodoRes> ImportantGroup(int groupIDG);
        TodoRes GetTodoById(int Id);

        int CreateTodo(CreateTodoReq request);
        int UpdateTodo(UpdateTodoReq request);
        bool FinishCheckbox(FinishCheckboxReq request);
        bool ImportantTodo(UpdateImportantReq request);

        int ProgressEdit(int Id);
        bool DeleteTodo(int Id);
        bool FinishTodo(int Id);
        bool DeleteFinish(int Id);
        bool DeleteImportant(int Id);


    }
}
