using Microsoft.EntityFrameworkCore;
using System.Linq;

public class ClientRepository
{
    private readonly HotelContext _hotelContext;

    public ClientRepository(HotelContext hotelContext)
    {
        _hotelContext = hotelContext;
    }

    public void Create(Clients client)
    {
        _hotelContext.Client.Add(client);
        _hotelContext.SaveChanges();
    }

    public Clients GetById(int id)
    {
        return _hotelContext.Client.AsNoTracking().Where(e => e.Id == id).FirstOrDefault();
    }
}