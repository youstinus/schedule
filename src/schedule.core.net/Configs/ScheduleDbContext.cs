using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using schedule.core.net.Models;

namespace schedule.core.net.Configs
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

        public ScheduleDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            SetUpGroup(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }

        private void SetUpGroup(ModelBuilder modelBuilder)
        {
            var entity = modelBuilder.Entity<Group>();
            entity.HasKey(x => x.Id);
            entity.HasMany(x => x.GroupLectures)
                .WithOne(x => x.Group)
                .HasForeignKey(x => x.GroupId)
                .OnDelete(DeleteBehavior.Cascade);
            entity.HasMany(x => x.GroupModules)
                .WithOne(x => x.Group)
                .HasForeignKey(x => x.GroupId)
                .OnDelete(DeleteBehavior.Cascade);
            entity.HasMany(x => x.Students)
                .WithOne(x => x.Group)
                .HasForeignKey(x => x.GroupId)
                .OnDelete(DeleteBehavior.Cascade);
            entity.HasOne(x => x.TimeTable)
                .WithMany(x => x.Groups)
                .HasForeignKey(x => x.TimeTableId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
