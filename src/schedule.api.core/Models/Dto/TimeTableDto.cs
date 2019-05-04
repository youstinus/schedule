using System.Collections.Generic;
using schedule.api.core.Base;

namespace schedule.api.core.Models.Dto
{
    public class TimeTableDto : BaseDto
    {
        public ICollection<TimeSlot> TimeSlots { get; set; }
        public ICollection<Module> Modules { get; set; }
        public ICollection<Room> Rooms { get; set; }
        public ICollection<Professor> Professors { get; set; }
        public ICollection<GroupDto> Groups { get; set; }
        public ICollection<Lecture> Lectures { get; set; }
    }
}
