﻿using System.Collections.Generic;
using schedule_core.Base;

namespace schedule_core.Models
{
    class TimeTable : BaseModel
    {
        public ICollection<TimeSlot> TimeSlots { get; set; }
        public ICollection<Module> Modules { get; set; }
        public ICollection<Room> Rooms { get; set; }
        public ICollection<Professor> Professors { get; set; }
        public ICollection<Group> Groups { get; set; }
        public ICollection<Lecture> Lectures { get; set; }
    }
}