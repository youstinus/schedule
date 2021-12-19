using schedule.api.core.Base;

namespace schedule.api.core.Models
{
    public class LectureTimeSlot : BaseEntity
    {
        public Lecture Lecture { get; set; }
        public TimeSlot TimeSlot { get; set; }

        public long LectureId { get; set; }
        public long TimeSlotId { get; set; }
    }
}
