using System;
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
            return _todoRepository.CreateTodo(request);
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
            return _todoRepository.DeleteTodo(Id);
        }

        public bool FinishCheckbox(FinishCheckboxReq request)
        {
            return _todoRepository.FinishCheckbox(request);
        }

        public IList<TodoRes> FinishGroup(int groupIDG)
        {
            return _todoRepository.FinishGroup(groupIDG);
        }

        public bool FinishTodo(int Id)
        {
            return _todoRepository.FinishTodo(Id);
        }

        public IList<TodoRes> GetListFinish()
        {
            return _todoRepository.GetListFinish();
        }


        public IList<TodoRes> GetListImportant()
        {
            return _todoRepository.GetListImportant();
        }


        public IList<TodoRes> GetTodoAllGroup()
        {
            return _todoRepository.GetTodoAllGroup();
        }

        public TodoRes GetTodoById(int Id)
        {
            return _todoRepository.GetTodoById(Id);
        }

        public IList<TodoRes> GetTodoListByGroup(int groupid)
        {
            return _todoRepository.GetTodoListByGroup(groupid);
        }

        public IList<TodoRes> ImportantGroup(int groupIDG)
        {
            return _todoRepository.ImportantGroup(groupIDG);
        }

        public bool ImportantTodo(UpdateImportantReq request)
        {
            return _todoRepository.ImportantTodo(request);
        }

        public int ProgressEdit(int Id)
        {
            return _todoRepository.ProgressEdit(Id);
        }

        public IList<TodoRes> SearchTask(string Task)
        {
            return _todoRepository.SearchTask(Task);
        }

        public IList<TodoRes> SearchTaskGroup(int groupIDG, string Task)
        {
            return _todoRepository.SearchTaskGroup(groupIDG, Task);
        }

        public int UpdateTodo(UpdateTodoReq request)
        {
            return _todoRepository.UpdateTodo(request);
        }
    }
}
