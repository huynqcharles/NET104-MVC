namespace FluentAPI.Models;

public class StudentClass
{
    public int StudentID { get; set; }
    public Student Student { get; set; }
    public int ClassID { get; set; }
    public Class Class { get; set; }
}