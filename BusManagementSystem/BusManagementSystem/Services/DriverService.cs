using System.Collections.Generic;
using System.Linq;
using BusManagementSystem.DTOS;
using BusManagementSystem.Entities;
using BusManagementSystem.Interfaces.Services;
using BusManagementSystem.Repositories;

namespace BusManagementSystem.Services
{
    public class DriverService: IDriverService
    {
        private readonly DriverRepository _driverRepository;

        public DriverService()
        {
            _driverRepository = new DriverRepository();
        }
        public bool Create(Driver driver)
        {
            var newDriver = new Driver
            {
                FullName = $"{driver.FirstName} {driver.LastName} {driver.MiddleName}",
                Address = driver.Address,
                Email = driver.Email,
                PhoneNumber = driver.PhoneNumber,
                Password = driver.Password
            };
            return true;
        }

        public Driver Update(Driver driver)
        {
            throw new System.NotImplementedException();
        }


        public Driver Update(string email, string password, Admin admin)
        {
            var driverChecking1 = _driverRepository.GetByEmail(email);
            var driverChecking2 = _driverRepository.GetByPassword(password);
            
            if (driverChecking1!=null && driverChecking2!=null)
            {
                driverChecking1.FullName = $"{admin.FirstName} {admin.MiddleName} {admin.LastName}";
                driverChecking1.Address = admin.Address;
                driverChecking1.Email = admin.Email;
                driverChecking1.PhoneNumber = admin.Password;
                driverChecking1.Password = admin.Password;

                _driverRepository.Update(driverChecking1);


            }

            return _driverRepository.Update(driverChecking1);
        }

        public Driver GetByEmail(string email)
        {
            return _driverRepository.GetByEmail(email);

        }

        public Driver GetByPassword(string password)
        {
            return _driverRepository.GetByPassword(password);
        }

        public bool Delete(Driver driver)
        {
           _driverRepository.Delete(driver);
           return true;
        }

        public Driver Get(int id)
        {
            var adnin = _driverRepository.Get(id);

            if (adnin==null)
            {
                throw new KeyNotFoundException($"The Driver with ID number {id} cannot be found.");
            }

            return adnin;
        }

        public bool ExistById(int id)
        {
            var check = _driverRepository.Get(id);
            if (check==null)
            {
                throw new KeyNotFoundException($"The Driver with Id number {id} cannot be found");
            }

            return _driverRepository.ExistById(check.Id);
        }

        public bool ExistByEmail(string email)
        {
            if (ExistByEmail(email))
            {
                return _driverRepository.ExistByEmail(email);
            }
            else
            {
                throw new KeyNotFoundException($"The Driver with email {email} does not exist. ");
            }
        }

        public List<DriverDto> GetAll()
        {
           return _driverRepository.GetAll().ToList().Select(driver=> new DriverDto
           {
               FullName= $"{driver.FirstName} {driver.LastName} {driver.MiddleName}",
               Address = driver.Address,
               Email = driver.Email,
               PhoneNumber = driver.PhoneNumber,
               Password = driver.Password
               
           }).ToList();
            
        }
    }
}