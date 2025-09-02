using System.ComponentModel.DataAnnotations;

namespace FarmaAPI.Models;

public class Sale
{
    public Guid Id { get; set; }
    public DateTime Date { get; set; }
    
    public Client Client { get; set; }
    public Guid ClientId { get; set; }
    public Product Product { get; set; }
    public Guid ProductId { get; set; }
    
}