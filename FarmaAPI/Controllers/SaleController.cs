using FarmaAPI.Models;
using FarmaAPI.DTO;
using FarmaAPI.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FarmaAPI.Controllers;

[ApiController]
[Route("api/sale")]
public class SaleController : ControllerBase
{
    private readonly SaleRepository _saleRepository;

    public SaleController(SaleRepository saleRepository)
    {
        _saleRepository = saleRepository;
    }

    [HttpGet(Name = "GetSales")]
    public IActionResult GetSales()
    {
        var sales = _saleRepository.GetSales();
        if (sales is null) return NotFound();
        return Ok(sales);
    }

    [HttpPost(Name = "CreateSale")]
    public IActionResult CreateSale(CreateSaleDTO dto)
    {
        var sale = _saleRepository.CreateSale(dto);
        return Ok(sale);
    }
}