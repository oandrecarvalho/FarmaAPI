namespace FarmaAPI.DTO;

public class CreateClientDTO
{
    public Guid Id { get; set; }
    public string Name;
    public int Cpf { get; set; }
    public string? Email { get; set; }
}