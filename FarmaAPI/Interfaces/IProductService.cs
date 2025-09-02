using FarmaAPI.DTO;
using FarmaAPI.Models;

namespace FarmaAPI.Interfaces;

public interface IProductService
{
    public List<Product> GetProducts();
    public Product CreateProduct(CreateProductDTO productDTO);
}