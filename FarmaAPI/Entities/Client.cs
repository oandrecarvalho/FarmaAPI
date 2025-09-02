using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FarmaAPI.Models;

public class Client
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public DateOnly Birth { get; set; }
    public int Cpf { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public virtual List<Sale> Sales { get; set; }
}