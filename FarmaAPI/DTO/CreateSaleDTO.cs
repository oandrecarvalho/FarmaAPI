using FarmaAPI.Models;

namespace FarmaAPI.DTO;

public class CreateSaleDTO
{
    public Guid SaleId;
    public DateTime Date;
    public Guid ClientId;
    public Guid ProductId;
    public int Stock;
}