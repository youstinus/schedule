using System.Collections.Generic;
using schedule_core.Base;

namespace schedule_core.Models
{
    class Group : BaseModel
    {
        public int Size { get; set; }
        public TimeTable TimeTable { get; set; }
        public ICollection<GroupLecture> GroupLectures { get; set; }
        public ICollection<GroupModule> GroupModules { get; set; }
        public ICollection<Student> Students { get; set; }

        public long TimeTableId { get; set; }
    }
}
