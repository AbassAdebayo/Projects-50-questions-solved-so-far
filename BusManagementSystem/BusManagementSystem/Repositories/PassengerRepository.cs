using System.Collections.Generic;
using System.Linq;
using BusManagementSystem.Context;
using BusManagementSystem.Entities;

namespace BusManagementSystem.Repositories
{
    public class PassengerRepository
    {
        private readonly BusManagementSystemDbContext _context;

        public PassengerRepository()
        {
            _context = new BusManagementSystemDbContext();
        }
        public Passenger Create(Passenger passenger)
        {
            _context.Add(passenger);
            _context.SaveChanges();
            return passenger;
        }

        public Passenger Update(Passenger passenger)
        {
            _context.Update(passenger);
            _context.SaveChanges();
            return passenger;
        }

        public bool Delete(int id)
        {
            var passenger = _context.Passengers.Find(id);
            if (passenger==null)
            {
                throw new KeyNotFoundException($"The passenger with Id {id} does not exist.");
            }
            _context.Remove(passenger);
            _context.SaveChanges();
            return true;
        }

        public Passenger Get(int id)
        {
            var passenger = _context.Passengers.Find(id);
            if (passenger==null)
            {
                throw new KeyNotFoundException($"The Passenger with Id number {id} does not exist.");
            }

            return passenger;
        }

        public bool ExistById(int id)
        {
            return _context.Passengers.Any(i => i.Id == id);
        }

        public bool ExistByEmail(string email)
        {
            return _context.Passengers.Any(e => e.Email == email);
        }

        public Passenger GetByEmail(string email)
        {
            return _context.Passengers.SingleOrDefault(e => e.Email == email);
        }

        public Passenger GetByPassword(string password)
        {
            return _context.Passengers.SingleOrDefault(p => p.Password == password);
        }

        public List<Passenger> GetAll()
        {
            return _context.Passengers.ToList();
        }
    }
}