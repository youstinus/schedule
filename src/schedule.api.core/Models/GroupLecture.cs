using schedule.api.core.Base;

namespace schedule.api.core.Models
{
    public class GroupLecture : BaseEntity
    {
        public Group Group { get; set; }
        public Lecture Lecture { get; set; }

        public long GroupId { get; set; }
        public long LectureId { get; set; }
    }
}
