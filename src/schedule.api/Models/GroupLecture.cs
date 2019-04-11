using schedule.api.Base;

namespace schedule.api.Models
{
    class GroupLecture : BaseModel
    {
        public Group Group { get; set; }
        public Lecture Lecture { get; set; }

        public long GroupId { get; set; }
        public long LectureId { get; set; }
    }
}
