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
    public class GroupRepository : BaseRepository, IGroupRepository
    {
        public int CreateGroupRP(CreateGroupReq request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@GroupName", request.GroupName);
                var id = SqlMapper.ExecuteScalar<int>(con, "CreateGroup", param: parameters, commandType: CommandType.StoredProcedure);
                return id;
            }
            catch (Exception ex)
            {
                throw ex;
                //return 0;
            }
        }

        public bool DeleteGroupRP(int id)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Id", id);

                var result = SqlMapper.ExecuteScalar<bool>(con, "DeleteGroup", param: parameters, commandType: CommandType.StoredProcedure);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
                //return 0;
            }
        }

        public GroupRes GetListGroupByIDRP(int id)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@Id", id);
            GroupRes getListGroupByIDRP = SqlMapper.Query<GroupRes>(con, "GetListGroupByID", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            return getListGroupByIDRP;
        }

        public IList<GroupRes> GetListGroupRP()
        {
            IList<GroupRes> getListGroupRP = SqlMapper.Query<GroupRes>(con, "GetListGroup", commandType: CommandType.StoredProcedure).ToList();
            return getListGroupRP;
        }

        public int UpdateGroupRP(UpdateGroupRes request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Id", request.IDG);
                parameters.Add("@GroupName", request.GroupName);
                var id = SqlMapper.ExecuteScalar<int>(con, "UpdateGroup", param: parameters, commandType: CommandType.StoredProcedure);
                return id;
            }
            catch (Exception ex)
            {
                throw ex;
                //return 0;
            }
        }
    }
}
