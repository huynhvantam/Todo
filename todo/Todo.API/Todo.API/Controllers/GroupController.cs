using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Todo.BAL.Interface;
using Todo.Domain.Request;
using Todo.Domain.Response;

namespace Todo.API.Controllers
{


    [ApiController]
    public class GroupController : ControllerBase
    {
        private readonly IGroupService _groupService;
        public GroupController(IGroupService groupService)
        {
            _groupService = groupService;
        }












        [HttpGet]
        [Route("api/group/getlistgroup")]
        public IEnumerable<GroupRes> GetListGroupCT()
        {
            return _groupService.GetListGroupSV();
        }



        [HttpGet]
        [Route("api/group/getlistgroupbyid/{id}")]
        public GroupRes GetListGroupByIDCT(int id)
        {
            return _groupService.GetListGroupByIDSV(id);
        }

        [HttpPost]
        [Route("api/group/creategroup")]
        public int CreateGroupCT([FromBody] CreateGroupReq request)
        {
            return _groupService.CreateGroupSV(request);
        }

        [HttpPut]
        [Route("api/group/updategroup")]
        public int UpdateGroupCT([FromBody] UpdateGroupRes request)
        {
            return _groupService.UpdateGroupSV(request);
        }

        [HttpDelete]
        [Route("api/group/deletegroup/{id}")]
        public bool DeleteGroupCT(int id)
        {
            return _groupService.DeleteGroupSV(id);
        }
    }
}
