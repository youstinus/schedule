using schedule.api.net.Base;

namespace schedule.api.net.Models
{
    class LectureProfessor : BaseModel
    {
        public Lecture Lecture { get; set; }
        public Professor Professor { get; set; }

        public long LectureId { get; set; }
        public long ProfessorId { get; set; }
}
}
