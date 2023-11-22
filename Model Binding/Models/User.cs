using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model_Binding.Models;

public class User
{
    [Key]
    public int Id { get; set; }
    [Column("user-name")]
    [Required]
    public string UserName { get; set; }
    [EmailAddress(ErrorMessage = "Wrong email")]
    public string UserEmail { get; set; }

    [DataType(DataType.Currency)]
    [DisplayFormat(DataFormatString = "{0:C0}", ApplyFormatInEditMode = true)]
    public float Price { get; set; }
}