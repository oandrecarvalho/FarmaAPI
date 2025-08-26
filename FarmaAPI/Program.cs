using FarmaAPI.Interfaces;
using FarmaAPI.Repositories;
using FarmaAPI.Services;

namespace FarmaAPI;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddAuthorization();

        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddTransient<IClientService, ClientService>();
        builder.Services.AddTransient<IClientRepository, ClientRepository>();
        builder.Services.AddTransient<IProductService, ProductService>();
        builder.Services.AddTransient<IProductRepository, ProductRepository>();
        builder.Services.AddTransient<ISaleService, SaleService>();
        builder.Services.AddTransient<ISaleRepository, SaleRepository>();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();
        
        app.MapControllers();

        app.Run();
    }
}