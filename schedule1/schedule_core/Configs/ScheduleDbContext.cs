using System.Data.Entity;
using schedule_core.Models;

namespace schedule_core.Configs
{
    class ScheduleDbContext : DbContext
    {
        public DbSet<Group> Groups { get; set; }
        public DbSet<GroupLecture> GroupLectures { get; set; }
        public DbSet<GroupModule> GroupModules { get; set; }
        public DbSet<Lecture> Lectures { get; set; }
        public DbSet<LectureProfessor> LectureProfessors { get; set; }
        public DbSet<LectureRoom> LectureRooms { get; set; }
        public DbSet<LectureTimeSlot> LectureTimeSlots { get; set; }
        public DbSet<Module> Modules { get; set; }
        public DbSet<ModuleProfessor> ModuleProfessors { get; set; }
        public DbSet<Professor> Professors { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<TimeSlot> TimeSlots { get; set; }
        public DbSet<TimeTable> TimeTables { get; set; }

        public ScheduleDbContext(DbContextOptions<ScheduleDbContext> options) : base(options)
        {

        }
    }
}
