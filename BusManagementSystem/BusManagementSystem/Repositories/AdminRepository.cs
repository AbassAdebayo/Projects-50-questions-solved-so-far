using System.Collections.Generic;
using System.Linq;
using BusManagementSystem.Context;
using BusManagementSystem.DTOS;
using BusManagementSystem.Entities;
using BusManagementSystem.Interfaces;

namespace BusManagementSystem.Repositories
{
    public class AdminRepository: IAdminRepository
    {
        private readonly BusManagementSystemDbContext _context;

        public AdminRepository()
        {
            _context = new BusManagementSystemDbContext();
        }
        public Admin Create(Admin admin)
        {
            _context.Add(admin);
            _context.SaveChanges();
            return admin;
        }

        public Admin Update(Admin admin)
        {
            _context.Update(admin);
            _context.SaveChanges();
            return admin;
        }

        public bool Delete(Admin admin)
        {
            _context.Remove(admin);
            _context.SaveChanges();
            return true;
        }

        public Admin Get(int id)
        {
            var admin = _context.Admins.Find(id);
            if (admin==null)
            {
                throw new KeyNotFoundException($"The Admin with Id number {id} does not exist.");
            }

            return admin;
        }

        public bool ExistById(int id)
        {
            return _context.Admins.Any(i => i.Id == id);
        }

        public bool ExistByEmail(string email)
        {
            return _context.Admins.Any(e => e.Email == email);
        }

        public Admin GetByEmail(string email)
        {
            return _context.Admins.SingleOrDefault(e => e.Email == email);
        }

        public Admin GetByPassword(string password)
        {
            return _context.Admins.SingleOrDefault(p => p.Password == password);
        }

        public List<Admin> GetAll()
        {
            return _context.Admins.ToList();
        }
    }
}