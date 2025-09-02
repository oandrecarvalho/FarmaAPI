using FarmaAPI.Models;
using FarmaAPI.DTO;

namespace FarmaAPI.Interfaces;

public interface IClientService
{
    public List<Client> GetClients();
    public Client CreateClient(CreateClientDTO clientDTO);
}