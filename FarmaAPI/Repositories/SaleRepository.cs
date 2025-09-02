using FarmaAPI.DTO;
using FarmaAPI.Interfaces;
using FarmaAPI.Models;
using FarmaAPI.Services;

namespace FarmaAPI.Repositories;

public class SaleRepository : ISaleRepository
{
    private readonly FarmaDbContext _context;

    public SaleRepository(FarmaDbContext context)
    {
        _context = context;
    }

    public void CreateSale(Sale sale)
    {
        _context.Add(sale);
        _context.SaveChanges();
    }   
    public List<Sale> GetSales()
    {
        List<Sale> sales = new List<Sale>();
        return sales;
    }
}