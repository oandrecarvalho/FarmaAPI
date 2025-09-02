using FarmaAPI.DTO;
using FarmaAPI.Interfaces;
using FarmaAPI.Models;

namespace FarmaAPI.Repositories;

public class ProductRepository : IProductRepository
{
    private readonly FarmaDbContext _context;

    public ProductRepository(FarmaDbContext context)
    {
        _context = context;
    }

    public void CreateProduct(Product product)
    {
        _context.Add(product);
        _context.SaveChanges();
    }

    public List<Product> GetProducts()
    {
        return _context.Products
            .Select(p => p)
            .ToList();
    }

    public Product FindById(Guid id)
    {
        return _context.Products
            .Select(p => p)
            .Where(p => p.Id.Equals(id))
            .First();
    }

    public Product Update(Product product)
    {
        _context.Update(product);
        _context.SaveChanges();
        return product;
    }
}