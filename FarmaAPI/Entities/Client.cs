using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FarmaAPI.Models;

public class Client
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }
    [Required]
    public string Name { get; set; }
    public DateOnly Birth { get; set; }
    [Required]
    public int Cpf { get; set; }
    [Required]
    public string Email { get; set; }
    public string Password { get; set; }

    public Client(string name, string email, int cpf)
    {
        Name = name;
        Email = email;
        Cpf = cpf;
    }
    
    private Client() { }
    
}