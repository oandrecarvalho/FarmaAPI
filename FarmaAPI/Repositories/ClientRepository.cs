// using FarmaAPI.Data.Context;
using FarmaAPI.DTO;
using FarmaAPI.Interfaces;
using FarmaAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FarmaAPI.Repositories;

public class ClientRepository : IClientRepository
{
    private readonly FarmaDbContext _context;
    
    public ClientRepository(FarmaDbContext context)
    {
        _context = context;
    }

    public Client FindById(Guid id)
    {
        return _context.Clients
            .Select(c => c)
            .Where(c => c.Id.Equals(id))
            .First();
    }
    
    public List<Client> GetClients()
    {
        return _context.Clients
            .Select(c => c)
            .ToList();
    }

    public void CreateClient(Client client)
    {
        _context.Add(client);
        _context.SaveChanges();
    }
}