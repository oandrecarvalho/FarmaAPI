using System.Xml.Linq;
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

    public Sale CreateSale(CreateSaleDTO saleDTO)
    {
        //Código antigo!
        // var client =  _clientRepository
        //     .GetClients()
        //     .FirstOrDefault(c => c.Id == saleDTO.ClientId);
        // if (client == null)
        // {
        //     throw new InvalidOperationException("Client not found");
        // }
        //
        // var product = _productRepository
        //     .GetProducts().FirstOrDefault(p => p.Id == saleDTO.ProductId);
        // if (product == null)
        // {
        //     throw new InvalidOperationException("Product not found");
        // }
        //
        // if (product.Stock < saleDTO.Stock)
        // {
        //     throw new InvalidOperationException("Insufficient stock");
        // }

        try
        {
            if (saleDTO == null)
            {
                throw new Exception("Invalid sale data");
            }

            if (saleDTO.ProductId == Guid.Empty)
            {
                throw new Exception("Invalid product");
            }

            if (saleDTO.ClientId == Guid.Empty)
            {
                throw new Exception("Invalid client");
            }
            
            Client clientOld = _clientRepository.FindById(saleDTO.ClientId);
            if (clientOld == null)
            {
                throw new Exception("Invalid client");
            }
            
            Product productOld = _productRepository.FindById(saleDTO.ProductId);
            if (productOld == null)
            {
                throw new Exception("Invalid product");
            }

            if (productOld.Stock < saleDTO.Stock)
            {
                throw new Exception("Insufficient stock");
            }
            
            productOld.Stock -= saleDTO.Stock;
            _productRepository.Update(productOld);
            
            var newSale = new Sale
            {
                ClientId = clientOld.Id,
                ProductId = productOld.Id,
                Date = DateTime.Now,
            };
            
            _saleRepository.CreateSale(newSale);
            
            return newSale;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public List<Sale> GetSales()
    {
        return _saleRepository.GetSales();
    }
}