using System.Collections.Generic;
using schedule.api.core.Base;

namespace schedule.api.core.Models.Dto
{
    public class LectureDto : BaseDto
    {
        public ModuleDto Module { get; set; }
        public TimeTableDto TimeTable { get; set; }
        public ICollection<LectureTimeSlot> LectureTimeSlots { get; set; }
        public ICollection<LectureRoom> LectureRooms { get; set; }
        public ICollection<LectureProfessor> LectureProfessors { get; set; }
        public ICollection<GroupLecture> LectureGroups { get; set; }

        public long ModuleId { get; set; }
        public long TimeTableId { get; set; }
    }
}
