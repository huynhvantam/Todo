﻿using System;
using System.Collections.Generic;
using System.Text;
using Todo.Domain.Request;
using Todo.Domain.Response;

namespace Todo.BAL.Interface
{
    public interface ITodoService
    {
        IList<TodoRes> GetTodoListByGroup(int groupid);
        IList<TodoRes> GetTodoAllGroup();

        IList<TodoRes> GetListImportant();
        IList<TodoRes> GetListImportantByGroup(int groupid);

        IList<TodoRes> GetListFinish();
        IList<TodoRes> GetListFinishByGroup(int groupid);
        TodoRes GetTodoById(int Id);

        bool FinishCheckbox(FinishCheckboxReq request);
        int CreateTodo(CreateTodoReq request);
        int UpdateTodo(UpdateTodoReq request);
        bool ImportantTodo(UpdateImportantReq request);


        bool DeleteTodo(int Id);
        bool FinishTodo(int Id);
        bool DeleteFinish(int Id);
        bool DeleteImportant(int Id);
        //int ProgressEditRP(UpdateProgress request);
        int ProgressEditRP(int Id);
    }
}
