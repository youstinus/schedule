using schedule.api.framework.Base;

namespace schedule.api.framework.Models
{
    class ModuleProfessor : BaseModel
    {
        public Module Module { get; set; }
        public Professor Professor { get; set; }

        public long ModuleId { get; set; }
        public long ProfessorId { get; set; }
    }
}
