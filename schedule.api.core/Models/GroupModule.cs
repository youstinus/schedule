using schedule.api.core.Base;

namespace schedule.api.core.Models
{
    public class GroupModule : BaseEntity
    {
        public Group Group { get; set; }
        public Module Module { get; set; }

        public long GroupId { get; set; }
        public long ModuleId { get; set; }
    }
}
