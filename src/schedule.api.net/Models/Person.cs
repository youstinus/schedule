using schedule.api.net.Base;

namespace schedule.api.net.Models
{
    class Person : BaseModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
    }
}
