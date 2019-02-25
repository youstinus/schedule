using schedule_api.Base;

namespace schedule_api.Models
{
    class LectureTimeSlot : BaseModel
    {
        public Lecture Lecture { get; set; }
        public TimeSlot TimeSlot { get; set; }

        public long LectureId { get; set; }
        public long TimeSlotId { get; set; }
    }
}
