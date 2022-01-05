using System.Collections.Generic;
using BusManagementSystem.Context;
using BusManagementSystem.Entities;
using BusManagementSystem.Interfaces;

namespace BusManagementSystem.Repositories
{
  
    public class BookingRepository: IBookingRepository
    {
        readonly BusManagementSystemDbContext _context;


        public BookingRepository()
        {
            _context = new BusManagementSystemDbContext();
        }
        public Booking Create(Booking booking)
        {
            _context.Bookings.Add(booking);
            _context.SaveChanges();
            return booking;
        }

        public Booking Get(int id)
        {
            var booking = _context.Bookings.Find(id);
            if (booking==null)
            {
                throw new KeyNotFoundException($"The booking with id: {id} does not exist.");
            }

            return booking;
        }

        public Booking Update(Booking booking)
        {
            var b= _context.Bookings.Find(booking.Id);
            if (b==null)
            {
                throw new KeyNotFoundException($"The booking with id: {booking.Id} does not exist.");
            }

            _context.Bookings.Update(booking);
            _context.SaveChanges();
            return booking;

        }

        public void Delete(Booking booking)
        {
            var b= _context.Bookings.Find(booking.Id);
            if (b==null)
            {
                throw new KeyNotFoundException($"The booking with id: {booking.Id} does not exist.");
            }
            else
            {
                _context.Bookings.Remove(booking);
                _context.SaveChanges();
            }
        }
        
    }
}