using FarmaAPI.DTO;
using FarmaAPI.Models;

namespace FarmaAPI.Interfaces;

public interface ISaleRepository
{
    public List<Sale> GetSales();
    public Sale CreateSale(CreateSaleDTO dto);
}