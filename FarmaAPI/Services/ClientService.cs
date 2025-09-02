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

    public Client CreateClient(CreateClientDTO clientDTO)
    {
        try
        {
            if (clientDTO == null)
            {
                throw new Exception("Invalid client data");
            }

            var newClient = new Client
            {
                Name = clientDTO.Name,
                Cpf = clientDTO.Cpf
            };
            
            _clientRepository.CreateClient(newClient);
            
            return newClient;
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    public List<Client> GetClients()
    {
        List<Client> clients = _clientRepository.GetClients();
        return clients;
    }
}