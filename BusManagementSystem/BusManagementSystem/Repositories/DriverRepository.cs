using System.Collections.Generic;
using System.Linq;
using BusManagementSystem.Context;
using BusManagementSystem.Entities;
using BusManagementSystem.Interfaces;

namespace BusManagementSystem.Repositories
{
    public class DriverRepository: IDriverRepository
    {
        private readonly BusManagementSystemDbContext _context;

        public DriverRepository()
        {
            _context = new BusManagementSystemDbContext();
        }

        public Driver Create(Driver driver)
        {
            _context.Drivers.Add(driver);
            _context.SaveChanges();
            return driver;
        }

        public void Delete(Driver driver)
        {
            _context.Drivers.Remove(driver);
            _context.SaveChanges();
        }

        public bool ExistById(int id)
        {
            return _context.Drivers.Any(s => s.Id == id);
        }

        public bool ExistByRegNumber(string licenseNumber)
        {
            return _context.Drivers.Any(d => d.LicenseNumber == licenseNumber);
        }

        public Driver Get(int id)
        {
            return _context.Drivers.Find(id);
        }

        public List<Driver> GetAll()
        {
            return _context.Drivers.ToList();
        }

        public Driver GetByLicenseNumber(string licenseNumber)
        {
            return _context.Drivers.SingleOrDefault(x => x.LicenseNumber == licenseNumber);
        }

        public Driver Update(Driver driver)
        {
            _context.Drivers.Update(driver);
            _context.SaveChanges();
            return driver;
        }

        public int Id
        { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }

        public Driver GetByEmail(string email)
        {
            return _context.Drivers.SingleOrDefault(e => e.Email == email);
        }

        public Driver GetByPassword(string password)
        {
            return _context.Drivers.SingleOrDefault(p => p.Password == password);
        }

        public bool ExistByEmail(string email)
        {
            return _context.Drivers.Any(e => e.Email == email);
        }
    }
}