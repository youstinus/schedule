using Microsoft.EntityFrameworkCore;
using schedule.api.core.Models;
using schedule.api.core.Models.Dto;
using GroupLecture = schedule.api.core.Models.GroupLecture;
using GroupModule = schedule.api.core.Models.GroupModule;
using Lecture = schedule.api.core.Models.Lecture;
using LectureProfessor = schedule.api.core.Models.LectureProfessor;
using LectureRoom = schedule.api.core.Models.LectureRoom;
using LectureTimeSlot = schedule.api.core.Models.LectureTimeSlot;
using Module = schedule.api.core.Models.Module;
using ModuleProfessor = schedule.api.core.Models.ModuleProfessor;
using Professor = schedule.api.core.Models.Professor;
using Room = schedule.api.core.Models.Room;
using Student = schedule.api.core.Models.Student;
using TimeSlot = schedule.api.core.Models.TimeSlot;
using TimeTable = schedule.api.core.Models.TimeTable;

namespace schedule.api.core.Configs
{
    public class ScheduleDbContext : DbContext
    {
        public DbSet<GroupDto> Groups { get; set; }
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
