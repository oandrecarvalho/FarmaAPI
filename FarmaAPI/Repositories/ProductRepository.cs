using FarmaAPI.DTO;
using FarmaAPI.Interfaces;
using FarmaAPI.Models;

namespace FarmaAPI.Repositories;

public class ProductRepository : IProductRepository
{
    private readonly IProductRepository _productRepository;

    public ProductRepository(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public Product CreateProduct(CreateProductDTO dto)
    {
        throw new NotImplementedException();
    }

    public List<Product> GetProducts()
    {
        List<Product> products = _productRepository.GetProducts();
        return products;
    }
}