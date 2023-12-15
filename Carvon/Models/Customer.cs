using Carvon.Commons;

namespace Carvon.Models;

public class Customer : Auditable
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public DateOnly DateOfBirth { get; set; }
}
