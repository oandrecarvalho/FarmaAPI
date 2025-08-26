using FarmaAPI.Data.Context;
using FarmaAPI.DTO;
using FarmaAPI.Interfaces;
using FarmaAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FarmaAPI.Repositories;

public class ClientRepository : IClientRepository
{
    private readonly DbContext _context;

    public ClientRepository(Context context)
    {
        _context = context;
    }
    
    private readonly IClientRepository _clientRepository;

    public ClientRepository(IClientRepository clientRepository)
    {
        _clientRepository = clientRepository;
    }
    
    public List<Client> GetClients()
    {
        return _context.Clients
            .Select(c => c)
            .ToList();
    }

    public Client CreateClient(CreateClientDTO dto)
    {
        throw new NotImplementedException();
    }
}