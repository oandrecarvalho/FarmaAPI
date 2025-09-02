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

    public Product CreateProduct(CreateProductDTO productDTO)
    {
        try
        {
            if (productDTO is null)
            {
                throw new Exception("Invalid product data");
            }

            var newProduct = new Product
            {
                Name = productDTO.Name,
                Description = productDTO.Description,
                Price = productDTO.Price,
                Stock = productDTO.Stock,

            };
            
            _productRepository.CreateProduct(newProduct);

            return newProduct;
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    public List<Product> GetProducts()
    {
        return _productRepository.GetProducts();
    }
}