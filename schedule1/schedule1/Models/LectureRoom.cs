using schedule1.Base;

namespace schedule1.Models
{
    class LectureRoom : BaseModel
    {
        public Lecture Lecture { get; set; }
        public Room Room { get; set; }

        public long LectureId { get; set; }
        public long RoomId { get; set; }
    }
}
