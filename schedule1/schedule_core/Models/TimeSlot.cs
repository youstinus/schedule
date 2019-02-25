using System.Collections.Generic;
using schedule_core.Base;
using schedule_core.Enums;

namespace schedule_core.Models
{
    class TimeSlot : BaseModel
    {
        public TimeSlots Time { get; set; }
        public TimeTable TimeTable { get; set; }
        public ICollection<LectureTimeSlot> TimeSlotLectures { get; set; }

        public long TimeTableId { get; set; }
    }
}
