﻿using System.Collections.Generic;

namespace schedule.api.framework.Models
{
    class Professor : Person
    {
        public TimeTable TimeTable { get; set; }
        public ICollection<LectureProfessor> ProfessorLectures { get; set; }
        public ICollection<ModuleProfessor> ProfessorModules { get; set; }

        public long TimeTableId { get; set; }
    }
}
