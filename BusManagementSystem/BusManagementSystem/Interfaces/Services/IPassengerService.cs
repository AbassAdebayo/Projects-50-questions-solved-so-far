using System.Collections.Generic;
using BusManagementSystem.DTOS;
using BusManagementSystem.Entities;

namespace BusManagementSystem.Interfaces.Services
{
    public interface IPassengerService
    
    { 
        bool Create(Passenger passenger);

        Passenger Update(Passenger passenger);

        bool Delete(int id, Passenger passenger);

        Passenger Get(int id);

        bool ExistById(int id);

        bool ExistByEmail(string email);

        List<PassengerDto> GetAll();

    }
}