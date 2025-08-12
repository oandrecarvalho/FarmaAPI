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
    [HttpGet]
    public IActionResult GetClients()
    {
        var client = _clientService.GetClient();
        return Ok(client);
    }
    
    
}