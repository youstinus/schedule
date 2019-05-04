using schedule.api.core.Base;

namespace schedule.api.core.Models.Dto
{
    public class StudentDto : BaseDto
    { // TODO add Stream and Manager
        public string Number { get; set; }
        public GroupDto Group { get; set; }

        public long GroupId { get; set; }
    }
}
