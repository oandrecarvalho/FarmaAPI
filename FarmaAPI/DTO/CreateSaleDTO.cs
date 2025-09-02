using FarmaAPI.Models;

namespace FarmaAPI.DTO;

public class CreateSaleDTO
{
    public Guid SaleId;
    public Guid ClientId;
    public Guid ProductId;
    public int Stock;
}