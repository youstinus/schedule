using schedule_core.Base;

namespace schedule_core.Models
{
    class GroupLecture : BaseModel
    {
        public Group Group { get; set; }
        public Lecture Lecture { get; set; }

        public long GroupId { get; set; }
        public long LectureId { get; set; }
    }
}
