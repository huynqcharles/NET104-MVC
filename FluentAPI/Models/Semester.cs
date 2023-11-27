namespace FluentAPI.Models;

public class Semester
{
    public int SemesterID { get; set; }
    public string SemesterName { get; set; }

    public List<Student> Students { get; set; }
}