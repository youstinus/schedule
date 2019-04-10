using System.Collections.Generic;
using schedule.core.net.Base;
using schedule.core.net.Enums;

namespace schedule.core.net.Models
{
    class TimeSlot : BaseModel
    {
        public TimeSlots Time { get; set; }
        public TimeTable TimeTable { get; set; }
        public ICollection<LectureTimeSlot> TimeSlotLectures { get; set; }

        public long TimeTableId { get; set; }
    }
}
