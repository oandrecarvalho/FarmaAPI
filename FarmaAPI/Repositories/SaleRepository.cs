using FarmaAPI.DTO;
using FarmaAPI.Interfaces;
using FarmaAPI.Models;

namespace FarmaAPI.Repositories;

public class SaleRepository : ISaleRepository
{
    private readonly ISaleRepository _saleRepository;

    public SaleRepository(ISaleRepository saleRepository)
    {
        _saleRepository = saleRepository;
    }

    public Sale CreateSale(CreateSaleDTO dto)
    {
        throw new NotImplementedException();
    }
    public List<Sale> GetSales()
    {
        List<Sale> sales = new List<Sale>();
        return sales;
    }
}