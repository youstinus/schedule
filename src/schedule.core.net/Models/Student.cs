namespace schedule.core.net.Models
{
    class Student : Person
    { // TODO add Stream and Manager
        public string Number { get; set; }
        public Group Group { get; set; }

        public long GroupId { get; set; }
    }
}
