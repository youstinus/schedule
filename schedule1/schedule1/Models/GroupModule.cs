namespace schedule1.Models
{
    class GroupModule
    {
        public Group Group { get; set; }
        public Module Module { get; set; }

        public long GroupId { get; set; }
        public long ModuleId { get; set; }
    }
}
