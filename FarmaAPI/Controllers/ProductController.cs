using FarmaAPI.DTO;
using FarmaAPI.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FarmaAPI.Controllers;

[ApiController]
[Route("api/product")]
public class ProductController : ControllerBase
{
    private readonly IProductService _productService;

    public ProductController(IProductService productService)
    {
        _productService = productService;
    }

    [HttpGet(Name = "GetProducts")]
    public IActionResult GetProducts()
    {
        var products = _productService.GetProducts();
        return Ok(products);
    }

    [HttpPost(Name = "CreateProduct")]
    public IActionResult CreateProduct([FromBody]CreateProductDTO dto)
    {
        var product = _productService.CreateProduct(dto);
        return Ok(product);
    }
}