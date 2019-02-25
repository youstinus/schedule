using System.Collections.Generic;

namespace schedule_api.Models
{
    class Professor : Person
    {
        public TimeTable TimeTable { get; set; }
        public ICollection<LectureProfessor> ProfessorLectures { get; set; }
        public ICollection<ModuleProfessor> ProfessorModules { get; set; }

        public long TimeTableId { get; set; }
    }
}
