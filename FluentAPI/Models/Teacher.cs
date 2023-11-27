namespace FluentAPI.Models;

public class Teacher
{
    public int TeacherID { get; set; }
    public string TeacherName { get; set; }
    public List<Student> Students { get; set; }
}