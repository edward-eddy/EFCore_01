using Assignment.Configurations;
using Assignment.Entities;
using Microsoft.EntityFrameworkCore;

namespace Assignment.Contexts
{
    internal class AppDbContext : DbContext
    {
        // 3. Fluent APIs
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Instructor>(I =>
            {
                I.HasKey(I => I.Id);

                I.Property(I => I.Name)
                 .IsRequired()
                 .HasColumnType("varchar");

                I.Property(I => I.Bouns).HasColumnType("money");

                I.Property(I => I.Bouns).IsRequired();
            });

            // 3. Fluent APIs

            modelBuilder.Entity<Stud_Course>().HasKey(SC => new { SC.Course_Id, SC.stud_Id });

            modelBuilder.Entity<Stud_Course>()
                        .Property(SC => SC.Grade)
                        .HasDefaultValue(0)
                        .HasColumnType("DECIMAL");


            // 4. Class Configuration
            modelBuilder.ApplyConfiguration(new StudentConfigs());

            modelBuilder.ApplyConfiguration(new TopicConfigs());

            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .; Database = EF01Assignment; Trusted_Connection = True; TrustServerCertificate = True;");
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Course_Inst> Course_Inst { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Stud_Course> Stud_Course { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Topic> Topics { get; set; }
    }
}
