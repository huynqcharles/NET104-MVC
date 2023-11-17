namespace HTML_Helpers.Models;

public class Employee
{
    public int EmployeeId { get; set; }
    public string? Name { get; set; }
    public Gender Gender { get; set; }
    public int Age { get; set; }
    public bool IsNewlyEnrolled { get; set; }
    public DateTime? DOB { get; set; }
}
public enum Gender
{
    Male,
    Female
}