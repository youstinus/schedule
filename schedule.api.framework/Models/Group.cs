﻿using System.Collections.Generic;
using schedule.api.framework.Base;

namespace schedule.api.framework.Models
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
