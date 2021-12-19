using System.Collections.Generic;
using schedule.api.framework.Base;
using schedule.api.framework.Enums;

namespace schedule.api.framework.Models
{
    class TimeSlot : BaseModel
    {
        public TimeSlots Time { get; set; }
        public TimeTable TimeTable { get; set; }
        public ICollection<LectureTimeSlot> TimeSlotLectures { get; set; }

        public long TimeTableId { get; set; }
    }
}
