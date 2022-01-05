using BusManagementSystem.Entities;
using MySqlX.XDevAPI.Common;

namespace BusManagementSystem.Interfaces
{
    public interface IBookingRepository
    {
        Booking Create(Booking booking);
        
        Booking Get(int id);

        Booking Update(Booking booking);
        
        void Delete(Booking booking);
    }
}