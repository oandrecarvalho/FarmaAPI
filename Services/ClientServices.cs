using FarmaAPI.Models;

namespace FarmaAPI.Services;

public class ClientServices
{
    public Client GetClient()
    {
        Client Client1 = new Client("André", "Andre@gmail.com", 19, 123456);
        return Client1;
    }
}