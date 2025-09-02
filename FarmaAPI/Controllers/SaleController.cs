using FarmaAPI.Models;
using FarmaAPI.DTO;
using FarmaAPI.Repositories;
using FarmaAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace FarmaAPI.Controllers;

[ApiController]
[Route("api/sale")]
public class SaleController : ControllerBase
{
    private readonly SaleService _saleService;

    public SaleController(SaleService saleService)
    {
        _saleService = saleService;
    }

    [HttpGet(Name = "GetSales")]
    public IActionResult GetSales()
    {
        var sales = _saleService.GetSales();
        if (sales is null) return NotFound();
        return Ok(sales);
    }

    [HttpPost(Name = "CreateSale")]
    public IActionResult CreateSale([FromBody]CreateSaleDTO dto)
    {
        try
        {
            var sale = _saleService.CreateSale(dto);
            return Ok(sale);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
        
    }
}