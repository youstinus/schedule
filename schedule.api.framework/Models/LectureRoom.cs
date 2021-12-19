using schedule.api.framework.Base;

namespace schedule.api.framework.Models
{
    class LectureRoom : BaseModel
    {
        public Lecture Lecture { get; set; }
        public Room Room { get; set; }

        public long LectureId { get; set; }
        public long RoomId { get; set; }
    }
}
