namespace Kattholt.Models;

public class Owner
{
    public int Id { get; set; }

    public string Name { get; set; }

    // Foreign key
    public int AddressId { get; set; }
    // Navigation propertyu
    public Address Address { get; set; }

    // Foreign key
    public int CatId { get; set; }
    // Navigation property
    public Cat Cat { get; set; }
    
}