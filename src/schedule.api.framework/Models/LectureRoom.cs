using schedule.api.Base;

namespace schedule.api.Models
{
    class LectureRoom : BaseModel
    {
        public Lecture Lecture { get; set; }
        public Room Room { get; set; }

        public long LectureId { get; set; }
        public long RoomId { get; set; }
    }
}
