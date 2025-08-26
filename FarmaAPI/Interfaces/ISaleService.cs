using FarmaAPI.DTO;
using FarmaAPI.Models;

namespace FarmaAPI.Interfaces;

public interface ISaleService
{
    public List<Sale> GetSales();
    public Sale CreateSale(CreateSaleDTO dto);
    
}