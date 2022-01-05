using System;
using System.Collections.Generic;
using System.Linq;
using BusManagementSystem.Context;
using BusManagementSystem.Entities;
using BusManagementSystem.Enums;
using BusManagementSystem.Interfaces;

namespace BusManagementSystem.Repositories
{
    public class BusRepository : IBusRepository
    {
        private readonly BusManagementSystemDbContext _context;

        public BusRepository()
        {
            _context = new BusManagementSystemDbContext();
        }

        public Bus Create(Bus bus)
        {
            _context.Buses.Add(bus);
            _context.SaveChanges();
            return bus;
        }

        public Bus Get(int id)
        {
            var bus = _context.Buses.Find(id);

            return bus;
        }

        public List<Bus> GetAll()
        {
            return _context.Buses.ToList();
        }

        public Bus GetByRegistrationNumber(string registrationNumber)
        {
            var bus = _context.Buses.SingleOrDefault(bus => bus.RegistrationNumber == registrationNumber);

            return bus;
        }

        public List<Bus> GetAvailableBuses()
        {
            return _context.Buses.Where(bus => bus.AvailabilityStatus == true).ToList();
        }

        public Bus Update(Bus bus)
        {
            _context.Buses.Update(bus);
            _context.SaveChanges();
            return bus;
        }

        public void Delete(Bus bus)
        {
            _context.Buses.Remove(bus);
            _context.SaveChanges();
        }

        public bool ExistById(int id)
        {
            return _context.Buses.Any(bus => bus.Id == id);
        }

        public bool ExistByRegNumber(string regNum)
        {
            return _context.Buses.Any(bus => bus.RegistrationNumber == regNum);
        }
    }
}