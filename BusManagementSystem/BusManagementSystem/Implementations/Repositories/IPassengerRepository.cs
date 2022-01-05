using System.Collections.Generic;
using BusManagementSystem.DTOS;
using BusManagementSystem.Entities;

namespace BusManagementSystem.Interfaces
{
    public interface IPassengerRepository
    {
        Passenger Create(Passenger passenger);

        Passenger Update(string email, string password);

        bool Delete(Passenger passenger);

        Passenger Get(int id);

        bool ExistById(int id);

        bool ExistByEmail(string email);

        List<PassengerDto> GetAll();
    }
}