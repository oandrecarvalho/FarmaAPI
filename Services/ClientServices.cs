using FarmaAPI.Models;

namespace FarmaAPI.Services;

public class ClientServices
{
    public Client GetClient()
    {
        Client Client1 = new Client("André", "Andre@gmail.com", 19, 123456);
        return Client1;
        Client Client2 = new Client("Henrique Almeida", "h.almeida@gmail.com", 25, 167765);
        return Client2;
    }

    public Client CreateClient()
    {
        Client Client1 = new Client("Andre", "Andre@gmail.com", 19, 123456);
        return Client1;
        Client Client2 = new Client("Henrique Almeida", "h.almeida@gmail.com", 25, 167765);
        return Client2;
    }
}