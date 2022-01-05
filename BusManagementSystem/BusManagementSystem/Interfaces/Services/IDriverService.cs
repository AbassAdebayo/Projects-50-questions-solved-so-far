using System.Collections.Generic;
using BusManagementSystem.DTOS;
using BusManagementSystem.Entities;

namespace BusManagementSystem.Interfaces.Services
{
    public interface IDriverService
    {
        bool Create(Driver driver);

        Driver Update(Driver driver);

        bool Delete(Driver driver);

        Driver Get(int id);

        bool ExistById(int id);

        bool ExistByEmail(string email);

        List<DriverDto> GetAll();

    }
}