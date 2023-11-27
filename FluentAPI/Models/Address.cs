namespace FluentAPI.Models;

public class Address
{
    public int AddressID { get; set; }
    public string AddressDetail { get; set; }
    public string City { get; set; }
    public string Country { get; set; }

    public Student Student { get; set; }
}