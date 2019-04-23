using System.Collections.Generic;
using schedule.api.Base;

namespace schedule.api.Models
{
    class Module : BaseModel
    {
        public string Code { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public TimeTable TimeTable { get; set; }
        public ICollection<GroupModule> ModuleGroups { get; set; }
        public ICollection<Lecture> Lectures { get; set; }
        public ICollection<ModuleProfessor> ModuleProfessors { get; set; }

        public long TimeTableId { get; set; }
    }
}
