using System.Collections.Generic;
using schedule.api.core.Base;

namespace schedule.api.core.Models
{
    public class Group : BaseEntity
    {
        public int Size { get; set; }
        public TimeTable TimeTable { get; set; }
        public ICollection<GroupLecture> GroupLectures { get; set; }
        public ICollection<GroupModule> GroupModules { get; set; }
        public ICollection<Student> Students { get; set; }

        public long TimeTableId { get; set; }
    }
}
