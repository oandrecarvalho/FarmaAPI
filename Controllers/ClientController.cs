using FarmaAPI.Models;
using Microsoft.AspNetCore.Mvc;
using FarmaAPI.Services;

namespace FarmaAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ClientController: ControllerBase
{
    private readonly ClientServices _clientService;
    public ClientController(ClientServices clientService)
    {
        _clientService = clientService;
    }
    
    [HttpGet(Name = "GetClients")]
    public IActionResult GetClients()
    {
        var clients = _clientService.GetClient();
        return Ok(clients);
    }

    [HttpPost(Name = "CreateClient")]
    public IActionResult CreateClient()
    {
        var client = _clientService.CreateClient();
        return Ok(client);
    }
    
    
}