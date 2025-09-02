using FarmaAPI.DTO;
using FarmaAPI.Models;

namespace FarmaAPI.Interfaces;

public interface IClientRepository
{
    public List<Client> GetClients();
    public Client FindById(Guid id);
    public void CreateClient(Client client);
}