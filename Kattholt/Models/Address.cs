using System.ComponentModel.DataAnnotations;

namespace Kattholt.Models;

public class Address
{
    public int Id { get; set; }

    [StringLength(255)]
    public string StreetName { get; set; }
    public int HouseNumer { get; set; }
    public int ZipCode { get; set; }
}