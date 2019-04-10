using schedule.core.net.Base;

namespace schedule.core.net.Models
{
    class GroupModule : BaseModel
    {
        public Group Group { get; set; }
        public Module Module { get; set; }

        public long GroupId { get; set; }
        public long ModuleId { get; set; }
    }
}
