using FarmaAPI.DTO;
using FarmaAPI.Models;
using Microsoft.AspNetCore.Mvc;
using FarmaAPI.Services;
using FarmaAPI.Interfaces;

namespace FarmaAPI.Controllers;

[ApiController]
[Route("api/client")]
public class ClientController: ControllerBase
{
    private readonly IClientService _clientService;
    public ClientController(IClientService clientService)
    {
        _clientService = clientService;
    }
    
    [HttpGet(Name = "GetClients")]
    public IActionResult GetClients()
    {
        var clients = _clientService.GetClients();
        return Ok(clients);
    }

    [HttpPost(Name = "CreateClient")]
    public IActionResult CreateClient(CreateClientDTO dto)
    {
        var client = _clientService.CreateClient(dto);
        return Ok(client);
    }
}