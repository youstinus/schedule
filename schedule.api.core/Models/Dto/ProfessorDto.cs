using System.Collections.Generic;
using schedule.api.core.Base;

namespace schedule.api.core.Models.Dto
{
    public class ProfessorDto : BaseDto
    {
        public TimeTableDto TimeTable { get; set; }
        public ICollection<LectureProfessor> ProfessorLectures { get; set; }
        public ICollection<ModuleProfessor> ProfessorModules { get; set; }

        public long TimeTableId { get; set; }
    }
}
