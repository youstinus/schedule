using schedule.core.net.Base;

namespace schedule.core.net.Models
{
    class GroupLecture : BaseModel
    {
        public Group Group { get; set; }
        public Lecture Lecture { get; set; }

        public long GroupId { get; set; }
        public long LectureId { get; set; }
    }
}
