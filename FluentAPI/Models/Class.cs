namespace FluentAPI.Models;

public class Class
{
    public int ClassID { get; set; }
    public string ClassName { get; set; }
    public List<StudentClass> StudentClasses { get; set; }
}