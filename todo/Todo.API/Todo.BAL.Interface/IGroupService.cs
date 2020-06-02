using System;
using System.Collections.Generic;
using System.Text;
using Todo.Domain.Request;
using Todo.Domain.Response;

namespace Todo.BAL.Interface
{
    public interface IGroupService
    {
        IList<GroupRes> GetListGroupSV();
        GroupRes GetListGroupByIDSV(int id);
        int CreateGroupSV(CreateGroupReq request);
        int UpdateGroupSV(UpdateGroupRes request);
        bool DeleteGroupSV(int id);
    }
}
