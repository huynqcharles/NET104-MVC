namespace FluentAPI.Models;

public class Student
{
    public int StudentID { get; set; }
    public string StudentName { get; set; }
    public DateTime DoB { get; set; }

    public Address Address { get; set; }
    public Semester Semester { get; set; }
    public List<StudentClass> StudentClasses { get; set; }
    public List<Teacher> Teachers { get; set; }
}