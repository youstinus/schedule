using schedule.api.core.Base;

namespace schedule.api.core.Models
{
    public class ModuleProfessor : BaseEntity
    {
        public Module Module { get; set; }
        public Professor Professor { get; set; }

        public long ModuleId { get; set; }
        public long ProfessorId { get; set; }
    }
}
