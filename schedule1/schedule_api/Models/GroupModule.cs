using schedule_api.Base;

namespace schedule_api.Models
{
    class GroupModule : BaseModel
    {
        public Group Group { get; set; }
        public Module Module { get; set; }

        public long GroupId { get; set; }
        public long ModuleId { get; set; }
    }
}
