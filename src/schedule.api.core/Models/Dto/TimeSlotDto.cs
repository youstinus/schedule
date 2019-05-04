using System.Collections.Generic;
using schedule.api.core.Base;
using schedule.api.core.Enums;

namespace schedule.api.core.Models.Dto
{
    public class TimeSlotDto : BaseDto
    {
        public TimeSlots Time { get; set; }
        public TimeTableDto TimeTable { get; set; }
        public ICollection<LectureTimeSlot> TimeSlotLectures { get; set; }

        public long TimeTableId { get; set; }
    }
}
