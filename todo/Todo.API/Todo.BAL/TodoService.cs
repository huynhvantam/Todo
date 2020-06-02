﻿using System;
using System.Collections.Generic;
using System.Text;
using Todo.BAL.Interface;
using Todo.DAL.Interface;
using Todo.Domain.Request;
using Todo.Domain.Response;

namespace Todo.BAL
{
    public class TodoService : ITodoService
    {

        private ITodoRepository _todoRepository;
        public TodoService(ITodoRepository todoRepository)
        {
            _todoRepository = todoRepository;
        }
        public int CreateTodo(CreateTodoReq request)
        {
            return _todoRepository.CreateTodoRP(request);
        }

        public bool DeleteFinish(int Id)
        {
            return _todoRepository.DeleteFinish(Id);
        }

        public bool DeleteImportant(int Id)
        {
            return _todoRepository.DeleteImportant(Id);
        }

        public bool DeleteTodo(int Id)
        {
            return _todoRepository.DeleteTodoRP(Id);
        }

        public bool FinishCheckbox(FinishCheckboxReq request)
        {
            return _todoRepository.FinishCheckbox(request);
        }

        public bool FinishTodo(int Id)
        {
            return _todoRepository.FinishTodoRP(Id);
        }

        public IList<TodoRes> GetListFinish()
        {
            return _todoRepository.GetListFinishRP();
        }

        public IList<TodoRes> GetListFinishByGroup(int groupid)
        {
            return _todoRepository.GetListFinishByGroupRP(groupid);
        }

        public IList<TodoRes> GetListImportant()
        {
            return _todoRepository.GetListImportantRP();
        }

        public IList<TodoRes> GetListImportantByGroup(int groupid)
        {
            return _todoRepository.GetListImportantByGroupRP(groupid);
        }

        public IList<TodoRes> GetTodoAllGroup()
        {
            return _todoRepository.GetTodoAllGroupRP();
        }

        public TodoRes GetTodoById(int Id)
        {
            return _todoRepository.GetTodoByIdRP(Id);
        }

        public IList<TodoRes> GetTodoListByGroup(int groupid)
        {
            return _todoRepository.GetTodoListByGroupRP(groupid);
        }

        public bool ImportantTodo(UpdateImportantReq request)
        {
            return _todoRepository.ImportantTodoRP(request);
        }

        public int ProgressEditRP(int Id)
        {
            return _todoRepository.ProgressEditRP(Id);
        }

        //public int ProgressEditRP(UpdateProgress request)
        //{
        //    return _todoRepository.ProgressEditRP(request);
        //}

        public int UpdateTodo(UpdateTodoReq request)
        {
            return _todoRepository.UpdateTodoRP(request);
        }
    }
}
