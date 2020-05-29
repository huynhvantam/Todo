using System;
using System.Collections.Generic;
using System.Text;
using Todo.Domain.Request;
using Todo.Domain.Response;

namespace Todo.DAL.Interface
{
    public interface ITodoRepository
    {
        IList<TodoRes> GetTodoListByGroupRP(int groupid);
        IList<TodoRes> GetTodoAllGroupRP();

        IList<TodoRes> GetListImportantRP();
        IList<TodoRes> GetListImportantByGroupRP(int groupid);

        IList<TodoRes> GetListFinishRP();
        IList<TodoRes> GetListFinishByGroupRP(int groupid);
        TodoRes GetTodoByIdRP(int Id);


        int CreateTodoRP(CreateTodoReq request);
        int UpdateTodoRP(UpdateTodoReq request);
        bool ImportantTodoRP(UpdateImportantReq request);


        bool DeleteTodoRP(int Id);
        bool FinishTodoRP(int Id);
    }
}
