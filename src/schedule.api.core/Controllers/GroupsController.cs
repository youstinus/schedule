using schedule.api.core.Models;
using schedule.api.core.Base;
using schedule.api.core.Base.Interfaces;
using schedule.api.core.Models.Dto;
using schedule.api.core.Controllers.Interfaces;

namespace schedule.api.core.Controllers
{
    public class GroupsController : BaseController<Group, GroupDto>, IGroupsController
    {
        public GroupsController(IBaseService<Group, GroupDto> service) : base(service)
        {
        }
    }
}
