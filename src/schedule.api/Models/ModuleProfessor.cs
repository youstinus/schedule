using schedule.api.Base;

namespace schedule.api.Models
{
    class ModuleProfessor : BaseModel
    {
        public Module Module { get; set; }
        public Professor Professor { get; set; }

        public long ModuleId { get; set; }
        public long ProfessorId { get; set; }
    }
}
