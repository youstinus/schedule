using schedule.api.Base;

namespace schedule.api.Models
{
    class GroupModule : BaseModel
    {
        public Group Group { get; set; }
        public Module Module { get; set; }

        public long GroupId { get; set; }
        public long ModuleId { get; set; }
    }
}
