using FarmaAPI.DTO;
using FarmaAPI.Interfaces;
using FarmaAPI.Models;

namespace FarmaAPI.Services;

public class ProductService : IProductService
{
    private readonly IProductRepository _productRepository;

    public ProductService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public Product CreateProduct(CreateProductDTO dto)
    {
        throw new NotImplementedException();
    }

    public List<Product> GetProducts()
    {
        return _productRepository.GetProducts();
    }
}