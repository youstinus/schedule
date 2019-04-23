using System.Collections.Generic;
using schedule.api.core.Base;
using schedule.api.core.Enums;

namespace schedule.api.core.Models
{
    public class TimeSlot : BaseEntity
    {
        public TimeSlots Time { get; set; }
        public TimeTable TimeTable { get; set; }
        public ICollection<LectureTimeSlot> TimeSlotLectures { get; set; }

        public long TimeTableId { get; set; }
    }
}
