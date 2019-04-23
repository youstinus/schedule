using schedule.api.core.Base;

namespace schedule.api.core.Models
{
    public class LectureProfessor : BaseEntity
    {
        public Lecture Lecture { get; set; }
        public Professor Professor { get; set; }

        public long LectureId { get; set; }
        public long ProfessorId { get; set; }
}
}
