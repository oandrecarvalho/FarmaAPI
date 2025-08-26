using FarmaAPI.DTO;
using FarmaAPI.Interfaces;
using FarmaAPI.Models;

namespace FarmaAPI.Services;

public class SaleService : ISaleService
{
    private readonly ISaleRepository _saleRepository;
    private readonly IProductRepository _productRepository;
    private readonly IClientRepository _clientRepository;

    public SaleService(ISaleRepository saleRepository, IProductRepository productRepository, IClientRepository clientRepository)
    {
        _saleRepository = saleRepository;
        _productRepository = productRepository;
        _clientRepository = clientRepository;
        
    }

    public Sale CreateSale(CreateSaleDTO dto)
    {
        var client =  _clientRepository
            .GetClients()
            .FirstOrDefault(c => c.Id == dto.ClientId);
        if (client == null)
        {
            throw new InvalidOperationException("Client not found");
        }

        var product = _productRepository
            .GetProducts().FirstOrDefault(p => p.Id == dto.ProductId);
        if (product == null)
        {
            throw new InvalidOperationException("Product not found");
        }
        
        if (product.Stock < dto.Stock)
        {
            throw new InvalidOperationException("Insufficient stock");
        }
        
        product.Stock -= dto.Stock;

        var sale = new Sale
        {
            Client = client,
            Products = product,
            Date = dto.Date,
        };
        
        return _saleRepository.CreateSale(dto);
    }

    public List<Sale> GetSales()
    {
        return _saleRepository.GetSales();
    }
}