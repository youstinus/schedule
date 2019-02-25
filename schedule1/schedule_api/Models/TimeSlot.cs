using System.Collections.Generic;
using schedule_api.Base;
using schedule_api.Enums;

namespace schedule_api.Models
{
    class TimeSlot : BaseModel
    {
        public TimeSlots Time { get; set; }
        public TimeTable TimeTable { get; set; }
        public ICollection<LectureTimeSlot> TimeSlotLectures { get; set; }

        public long TimeTableId { get; set; }
    }
}
