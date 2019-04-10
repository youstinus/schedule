using System.Collections.Generic;
using schedule.core.net.Base;
using schedule.core.net.Enums;

namespace schedule.core.net.Models
{
    class Room : BaseModel
    {
        public string Number { get; set; }
        public Faculties Faculty { get; set; }
        public int Capacity { get; set; }
        public TimeTable TimeTable { get; set; }
        public ICollection<LectureRoom> RoomLectures { get; set; }

        public long TimeTableId { get; set; }
        // TODO consider adding type of room: computers, has multimedia, etc.
    }
}
