using FluentAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FluentAPI.Context;

public class MyDBContext : DbContext
{
    public MyDBContext(DbContextOptions<MyDBContext> options) : base(options)
    {
            
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Student>()
            .Property(s => s.DoB).HasColumnName("Date of Birth");
        
        // Config 1-1 relationship
        modelBuilder.Entity<Student>()
            .HasOne(s => s.Address)
            .WithOne(a => a.Student)
            .HasForeignKey<Address>(a => a.AddressID);
        
        // Config 1-n relationship
        modelBuilder.Entity<Semester>()
            .HasMany(se => se.Students)
            .WithOne(st => st.Semester)
            .OnDelete(DeleteBehavior.Cascade);

        // modelBuilder.Entity<Student>()
        //     .HasOne(st => st.Semester)
        //     .WithMany(se => se.Students);
        
        // Config n-n relationship
        modelBuilder.Entity<StudentClass>()
            .HasKey(sc => new { sc.StudentID, sc.ClassID });

        modelBuilder.Entity<StudentClass>()
            .HasOne(sc => sc.Student)
            .WithMany(st => st.StudentClasses);
        
        modelBuilder.Entity<StudentClass>()
            .HasOne(sc => sc.Class)
            .WithMany(cl => cl.StudentClasses);
        
        // Config n-n 2
        modelBuilder.Entity<Student>()
            .HasMany(st => st.Teachers)
            .WithMany(tc => tc.Students)
            .UsingEntity(ts => ts.ToTable("StudentTeacher"));
    }

    public DbSet<Student> Students { get; set; }
    public DbSet<Address> Addresses { get; set; }
    public DbSet<Semester> Semesters { get; set; }
    public DbSet<Class> Classes { get; set; }
    public DbSet<StudentClass> StudentClasses { get; set; }
    public DbSet<Teacher> Teachers { get; set; }
}