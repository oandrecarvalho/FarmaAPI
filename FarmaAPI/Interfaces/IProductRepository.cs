using FarmaAPI.DTO;
using FarmaAPI.Models;
    
namespace FarmaAPI.Interfaces;

public interface IProductRepository
{
    public List<Product> GetProducts();
    public Product FindById(Guid id);
    public void CreateProduct(Product product);
    public Product Update(Product product);
}