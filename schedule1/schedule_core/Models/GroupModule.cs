using schedule_core.Base;

namespace schedule_core.Models
{
    class GroupModule : BaseModel
    {
        public Group Group { get; set; }
        public Module Module { get; set; }

        public long GroupId { get; set; }
        public long ModuleId { get; set; }
    }
}
