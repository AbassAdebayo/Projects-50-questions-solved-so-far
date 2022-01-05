using System.Collections.Generic;
using BusManagementSystem.Entities;

namespace BusManagementSystem.Interfaces
{
    public interface IAdminRepository
    {
        Admin Create(Admin admin);

        Admin Update(Admin admin);

        bool Delete(Admin admin);

        Admin Get(int id);

        bool ExistById(int id);

        bool ExistByEmail(string email);

        List<Admin> GetAll();
        
        


    }
}