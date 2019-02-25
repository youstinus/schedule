﻿using System.Collections.Generic;
using schedule_api.Base;

namespace schedule_api.Models
{
    class Lecture : BaseModel
    {
        public Module Module { get; set; }
        public TimeTable TimeTable { get; set; }
        public ICollection<LectureTimeSlot> LectureTimeSlots { get; set; }
        public ICollection<LectureRoom> LectureRooms { get; set; }
        public ICollection<LectureProfessor> LectureProfessors { get; set; }
        public ICollection<GroupLecture> LectureGroups { get; set; }

        public long ModuleId { get; set; }
        public long TimeTableId { get; set; }
    }
}
