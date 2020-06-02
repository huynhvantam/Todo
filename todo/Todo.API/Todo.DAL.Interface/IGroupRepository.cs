using System;
using System.Collections.Generic;
using System.Text;
using Todo.Domain.Request;
using Todo.Domain.Response;

namespace Todo.DAL.Interface
{
    public interface IGroupRepository
    {
        IList<GroupRes> GetListGroupRP();
        GroupRes GetListGroupByIDRP(int id);
        int CreateGroupRP(CreateGroupReq request);
        int UpdateGroupRP(UpdateGroupRes request);
        bool DeleteGroupRP(int id);
    }
}
