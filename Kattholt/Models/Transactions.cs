using System.ComponentModel.DataAnnotations.Schema;

namespace Kattholt.Models;

public class CatTransactions
{
    public int Id { get; set; }

    public int CatId { get; set; }
    public Cat Cat { get; set; }

    [ForeignKey("Owner")]
    public int OldOwnerId { get; set; }
    
    [ForeignKey("Owner")]
    public int NewOwnerId { get; set; }
    

    public DateTime TurnedInTime { get; set; } = DateTime.Now;
    public DateTime? AdoptedTime { get; set; } = null;
    
}