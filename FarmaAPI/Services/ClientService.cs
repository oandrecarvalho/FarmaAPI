using FarmaAPI.Interfaces;
using FarmaAPI.Models;
using FarmaAPI.DTO;

namespace FarmaAPI.Services;

public class ClientService : IClientService
{
    private readonly IClientRepository _clientRepository;

    public ClientService(IClientRepository clientRepository)
    {
        _clientRepository = clientRepository;
    }

    public Client CreateClient(CreateClientDTO dto)
    {
        throw new NotImplementedException();
    }

    public List<Client> GetClients()
    {
        return _clientRepository.GetClients();
    }
}