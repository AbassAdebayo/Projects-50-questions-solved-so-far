using System.Collections.Generic;
using BusManagementSystem.Entities;

namespace BusManagementSystem.Interfaces
{
    public interface IBusRepository
    {
        Bus Create(Bus bus);

        Bus Get(int id);

        List<Bus> GetAll();

        Bus GetByRegistrationNumber(string registrationNumber);

        List<Bus> GetAvailableBuses();

        Bus Update(Bus bus);

        void Delete(Bus bus);

        bool ExistById(int id);

        bool ExistByRegNumber(string regNum);
    }
}