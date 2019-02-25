using System.Collections.Generic;
using schedule1.Base;
using schedule1.Enums;

namespace schedule1.Models
{
    class TimeSlot : BaseModel
    {
        public TimeSlots Time { get; set; }
        public TimeTable TimeTable { get; set; }
        public ICollection<LectureTimeSlot> TimeSlotLectures { get; set; }

        public long TimeTableId { get; set; }
    }
}
