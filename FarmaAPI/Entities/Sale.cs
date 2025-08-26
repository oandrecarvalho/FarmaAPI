using System.ComponentModel.DataAnnotations;

namespace FarmaAPI.Models;

public class Sale
{
    [Key]
    public Guid Id { get; set; }
    public DateTime Date { get; set; }
    
    public Client Client { get; set; }
    
    public Product Products { get; set; }

    public Sale()
    {
    }
}