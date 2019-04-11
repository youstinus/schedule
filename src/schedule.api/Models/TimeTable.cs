using System.Collections.Generic;
using schedule.api.Base;

namespace schedule.api.Models
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
