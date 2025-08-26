using FarmaAPI.DTO;
using FarmaAPI.Models;

namespace FarmaAPI.Interfaces;

public interface IProductRepository
{
    public List<Product> GetProducts();
    public Product CreateProduct(CreateProductDTO dto);
}