using System.ComponentModel.DataAnnotations;

namespace EFDataAccess.Models;

public class User
{
    [Key]
    public int UserId { get; set; } = 0;
    public string FirstName { get; set; } = "";
    public string LastName { get; set; } = "";
    public string Password { get; set; } = "";
}