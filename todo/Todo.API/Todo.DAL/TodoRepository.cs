using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Todo.DAL.Interface;
using Todo.Domain.Request;
using Todo.Domain.Response;

namespace Todo.DAL
{
    public class TodoRepository : BaseRepository, ITodoRepository
    {

        public IList<TodoRes> GetListFinishByGroupRP(int groupid)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@GroupIDG", groupid);
            IList<TodoRes> getListFinishByGroupRP = SqlMapper.Query<TodoRes>(con, "GetListFinishByGroup", commandType: CommandType.StoredProcedure).ToList();
            return getListFinishByGroupRP;
        }

        public IList<TodoRes> GetTodoListByGroupRP(int groupid)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@GroupIDG", groupid);
            IList<TodoRes> getTodoListByGroupRP = SqlMapper.Query<TodoRes>(con, "GetTodoListByGroup", parameters, commandType: CommandType.StoredProcedure).ToList();
            return getTodoListByGroupRP;
        }
        public IList<TodoRes> GetListFinishRP()
        {
            IList<TodoRes> getListFinishRP = SqlMapper.Query<TodoRes>(con, "GetListFinish", commandType: CommandType.StoredProcedure).ToList();
            return getListFinishRP;
        }

        public IList<TodoRes> GetListImportantRP()
        {
            IList<TodoRes> getListImportant = SqlMapper.Query<TodoRes>(con, "GetListImportant", commandType: CommandType.StoredProcedure).ToList();
            return getListImportant;
        }

        public IList<TodoRes> GetListImportantByGroupRP(int groupid)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@GroupIDG", groupid);
            IList<TodoRes> getListImportantByGroup = SqlMapper.Query<TodoRes>(con, "GetListImportantByGroup", commandType: CommandType.StoredProcedure).ToList();
            return getListImportantByGroup;
        }

        public IList<TodoRes> GetTodoAllGroupRP()
        {
            IList<TodoRes> getTodoAllGroupRP = SqlMapper.Query<TodoRes>(con, "GetTodoAllGroup", commandType: CommandType.StoredProcedure).ToList();
            return getTodoAllGroupRP;
        }

        public TodoRes GetTodoByIdRP(int Id)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@Id", Id);
            TodoRes getTodoByIdRP = SqlMapper.Query<TodoRes>(con, "GetTodoById", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            return getTodoByIdRP;
        }


        public int CreateTodoRP(CreateTodoReq request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@TaskName", request.TaskName);
                parameters.Add("@Important", request.Important);
                parameters.Add("@GroupIDG", request.GroupIDG);
                parameters.Add("@Progress", request.Progress);
                var id = SqlMapper.ExecuteScalar<int>(con, "CreateTodo", param: parameters, commandType: CommandType.StoredProcedure);
                return id;
            }
            catch (Exception ex)
            {
                //throw ex;
                return 0;
            }
        }

        public int UpdateTodoRP(UpdateTodoReq request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Id", request.ID);
                parameters.Add("@TaskName", request.TaskName);
                parameters.Add("@Important", request.Important);
                parameters.Add("@Finish", request.Finish);
                parameters.Add("@GroupIDG", request.GroupIDG);
                var id = SqlMapper.ExecuteScalar<int>(con, "UpdateTodo", param: parameters, commandType: CommandType.StoredProcedure);
                return id;
            }
            catch (Exception ex)
            {
                //throw ex;
                return 0;
            }
        }

        public bool ImportantTodoRP(UpdateImportantReq request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Id", request.ID);

                parameters.Add("@Important", request.Important);

                var id = SqlMapper.ExecuteScalar<bool>(con, "ImportantTodo", param: parameters, commandType: CommandType.StoredProcedure);
                return id;
            }
            catch (Exception ex)
            {
                throw ex;
                //return 0;
            }
        }


        public bool DeleteTodoRP(int Id)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Id", Id);
                var id = SqlMapper.ExecuteScalar<bool>(con, "DeleteTodo", param: parameters, commandType: CommandType.StoredProcedure);
                return id;
            }
            catch (Exception ex)
            {
                throw ex;
                //return 0;
            }
        }
        public bool FinishTodoRP(int Id)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Id", Id);
                var id = SqlMapper.ExecuteScalar<bool>(con, "FinishTodo", param: parameters, commandType: CommandType.StoredProcedure);
                return id;
            }
            catch (Exception ex)
            {
                throw ex;
                //return 0;
            }
        }

        public bool FinishCheckbox(FinishCheckboxReq request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Id", request.ID);


                parameters.Add("@Finish", request.Finish);
                var id = SqlMapper.ExecuteScalar<bool>(con, "FinishCheckbox", param: parameters, commandType: CommandType.StoredProcedure);
                return id;
            }
            catch (Exception ex)
            {
                throw ex;
                //return 0;
            }
        }

        public bool DeleteFinish(int Id)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Id", Id);
                var id = SqlMapper.ExecuteScalar<bool>(con, "FinishCheckbox", param: parameters, commandType: CommandType.StoredProcedure);
                return id;
            }
            catch (Exception ex)
            {
                throw ex;
                //return 0;
            }
        }

        public bool DeleteImportant(int Id)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Id", Id);
                var id = SqlMapper.ExecuteScalar<bool>(con, "ImportantCheckbox", param: parameters, commandType: CommandType.StoredProcedure);
                return id;
            }
            catch (Exception ex)
            {
                throw ex;
                //return 0;
            }
        }
        public int ProgressEditRP(int Id)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Id", Id);
                var id = SqlMapper.ExecuteScalar<int>(con, "ProgressEdit", param: parameters, commandType: CommandType.StoredProcedure);
                return id;
            }
            catch (Exception ex)
            {
                throw ex;
                //return 0;
            }
        }
        //public int ProgressEditRP(UpdateProgress request)
        //{
        //    try
        //    {
        //        DynamicParameters parameters = new DynamicParameters();
        //        parameters.Add("@Id", request.ID);
        //        var id = SqlMapper.ExecuteScalar<int>(con, "ProgressEdit", param: parameters, commandType: CommandType.StoredProcedure);
        //        return id;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //        //return 0;
        //    }

        //}
    }
}
