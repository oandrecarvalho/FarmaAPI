using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FarmaAPI.Models;

public class Client
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string Id { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public int Age { get; set; }
    [Required]
    public int Cpf { get; set; }
    [Required]
    public string Email { get; set; }
    public string Phone { get; set; }

    public Client(string name, string email, int age, int cpf)
    {
        Name = name;
        Email = email;
        Age = age;
        Cpf = cpf;
    }
    
    private Client() { }
    
}