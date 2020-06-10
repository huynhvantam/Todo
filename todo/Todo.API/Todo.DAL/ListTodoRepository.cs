using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Dapper;
using Todo.DAL.Interface;
using Todo.Domain.Request;
using Todo.Domain.Response;
using System.Linq;

namespace Todo.DAL
{
    public class ListTodoRepository : BaseRepository, IListTodoRepository
    {
        public IList<ListTodoRes> GetListTodo(int TodoId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@TodoID", TodoId);
            IList<ListTodoRes> getListTodo = SqlMapper.Query<ListTodoRes>(con, "GetListTodo", parameters, commandType: CommandType.StoredProcedure).ToList();
            return getListTodo;
        }

        public ListTodoRes GetListTodoByIDL(int Idl)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@IDL", Idl);
            ListTodoRes getListTodoByIDL = SqlMapper.Query<ListTodoRes>(con, "GetListTodoByIDL", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            return getListTodoByIDL;
        }


        public int CreateListTodo(CreateListTodo request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@TodoID", request.TodoID);
                parameters.Add("@ListName", request.ListName);
                var id = SqlMapper.ExecuteScalar<int>(con, "CreateListTodo", parameters, commandType: CommandType.StoredProcedure);
                return id;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int UpdateListTodo(UpdateListTodo request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@IDL", request.IDL);
                parameters.Add("@TodoID", request.TodoID);
                parameters.Add("@ListName", request.ListName);
                var id = SqlMapper.ExecuteScalar<int>(con, "UpdateListTodo", parameters, commandType: CommandType.StoredProcedure);
                return id;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public bool DeleteListTodo(int Id)
        {

            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@IDL", Id);
                var id = SqlMapper.ExecuteScalar<bool>(con, "DeleteListTodo", parameters, commandType: CommandType.StoredProcedure);
                return id;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public bool FinishListTodo(int Id)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@IDL", Id);
                var id = SqlMapper.ExecuteScalar<bool>(con, "FinishListTodo", parameters, commandType: CommandType.StoredProcedure);
                return id;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

    }
}
