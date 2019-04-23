using schedule.api.core.Base;

namespace schedule.api.core.Models
{
    public class LectureRoom : BaseEntity
    {
        public Lecture Lecture { get; set; }
        public Room Room { get; set; }

        public long LectureId { get; set; }
        public long RoomId { get; set; }
    }
}
