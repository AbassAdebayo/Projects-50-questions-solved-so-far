using System.Collections.Generic;
using System.Linq;
using BusManagementSystem.DTOS;
using BusManagementSystem.Entities;
using BusManagementSystem.Interfaces.Services;
using BusManagementSystem.Repositories;

namespace BusManagementSystem.Services
{
    public class AdminService: IAdminService
    {
        private readonly AdminRepository _adminRepository;

        public AdminService()
        {
            _adminRepository = new AdminRepository();
        }
        public bool Create(Admin admin)
        {
            var newAdmin = new Admin
            {
                FullName = $"{admin.FirstName} {admin.LastName} {admin.MiddleName}",
                Address = admin.Address,
                Email = admin.Email,
                PhoneNumber = admin.PhoneNumber,
                Password = admin.Password

            };
            return true;
        }

        public Admin Update(Admin admin)
        {
            throw new System.NotImplementedException();
        }


        public Admin Update(string email, string password, Admin admin)
        {
            var adminChecking1 = _adminRepository.GetByEmail(email);
            var adminChecking2 = _adminRepository.GetByPassword(password);
            
            if (adminChecking1!=null && adminChecking2!=null)
            {
                adminChecking1.FullName = $"{admin.FirstName} {admin.MiddleName} {admin.LastName}";
                adminChecking1.Address = admin.Address;
                adminChecking1.Email = admin.Email;
                adminChecking1.PhoneNumber = admin.Password;
                adminChecking1.Password = admin.Password;

                _adminRepository.Update(adminChecking1);


            }

            return _adminRepository.Update(adminChecking1);
        }

        public Admin GetByEmail(string email)
        {
            return _adminRepository.GetByEmail(email);

        }

        public Admin GetByPassword(string password)
        {
            return _adminRepository.GetByPassword(password);
        }

        public bool Delete(Admin admin)
        {
            return _adminRepository.Delete(admin);
        }

        public Admin Get(int id)
        {
            var adnin = _adminRepository.Get(id);

            if (adnin==null)
            {
                throw new KeyNotFoundException($"The Admin with ID number {id} cannot be found.");
            }

            return adnin;
        }

        public bool ExistById(int id)
        {
            var check = _adminRepository.Get(id);
            if (check==null)
            {
                throw new KeyNotFoundException($"The Admin with Id number {id} cannot be found");
            }

            return _adminRepository.ExistById(check.Id);
        }

        public bool ExistByEmail(string email)
        {
            if (ExistByEmail(email))
            {
                return _adminRepository.ExistByEmail(email);
            }
            else
            {
                throw new KeyNotFoundException($"The Admin with email {email} does not exist. ");
            }
        }

        public List<Admin> GetAll()
        {
           return _adminRepository.GetAll().ToList();
            
        }
    }
}