using System.Collections.Generic;
using BusManagementSystem.DTOS;
using BusManagementSystem.Entities;

namespace BusManagementSystem.Interfaces.Services
{
    public interface IAdminService
    {

        bool Create(Admin admin);

        Admin Update(Admin admin);

        bool Delete(Admin admin);

        Admin Get(int id);

        bool ExistById(int id);

        bool ExistByEmail(string email);

        List<Admin> GetAll();

    }
}