﻿using schedule_core.Base;

namespace schedule_core.Models
{
    class ModuleProfessor : BaseModel
    {
        public Module Module { get; set; }
        public Professor Professor { get; set; }

        public long ModuleId { get; set; }
        public long ProfessorId { get; set; }
    }
}
