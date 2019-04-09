using System.Collections.Generic;
using schedule.api.net.Base;
using schedule.api.net.Enums;

namespace schedule.api.net.Models
{
    class TimeSlot : BaseModel
    {
        public TimeSlots Time { get; set; }
        public TimeTable TimeTable { get; set; }
        public ICollection<LectureTimeSlot> TimeSlotLectures { get; set; }

        public long TimeTableId { get; set; }
    }
}
