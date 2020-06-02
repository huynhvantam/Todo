using System;
using System.Collections.Generic;
using System.Text;
using Todo.BAL.Interface;
using Todo.DAL.Interface;
using Todo.Domain.Request;
using Todo.Domain.Response;

namespace Todo.BAL
{

    public class GroupService : IGroupService
    {
        private IGroupRepository _groupRepository;
        public GroupService(IGroupRepository groupRepository)
        {
            _groupRepository = groupRepository;
        }
        public int CreateGroupSV(CreateGroupReq request)
        {
            return _groupRepository.CreateGroupRP(request);
        }

        public bool DeleteGroupSV(int id)
        {
            return _groupRepository.DeleteGroupRP(id);
        }

        public GroupRes GetListGroupByIDSV(int id)
        {
            return _groupRepository.GetListGroupByIDRP(id);
        }

        public IList<GroupRes> GetListGroupSV()
        {
            return _groupRepository.GetListGroupRP();
        }

        public int UpdateGroupSV(UpdateGroupRes request)
        {
            return _groupRepository.UpdateGroupRP(request);
        }
    }
}
