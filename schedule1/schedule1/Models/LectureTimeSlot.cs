using schedule1.Base;

namespace schedule1.Models
{
    class LectureTimeSlot : BaseModel
    {
        public Lecture Lecture { get; set; }
        public TimeSlot TimeSlot { get; set; }

        public long LectureId { get; set; }
        public long TimeSlotId { get; set; }
    }
}
