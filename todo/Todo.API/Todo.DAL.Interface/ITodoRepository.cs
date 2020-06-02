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
        IList<TodoRes> GetListFinishByGroupRP(int id);
        TodoRes GetTodoByIdRP(int Id);


        int CreateTodoRP(CreateTodoReq request);
        int UpdateTodoRP(UpdateTodoReq request);

        bool FinishCheckbox(FinishCheckboxReq request);
        bool ImportantTodoRP(UpdateImportantReq request);


        bool DeleteTodoRP(int Id);
        bool FinishTodoRP(int Id);
        bool DeleteFinish(int Id);
        bool DeleteImportant(int Id);
    }
}
