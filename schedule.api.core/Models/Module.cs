﻿using System.Collections.Generic;
using schedule.api.core.Base;

namespace schedule.api.core.Models
{
    public class Module : BaseEntity
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
