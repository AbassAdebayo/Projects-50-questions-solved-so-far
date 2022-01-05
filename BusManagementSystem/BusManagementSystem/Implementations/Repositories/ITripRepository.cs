using System;
using System.Collections.Generic;
using BusManagementSystem.DTOS;
using BusManagementSystem.Entities;
using BusManagementSystem.Enums;

namespace BusManagementSystem.Interfaces

{
    public interface ITripRepository
    {
        Trip Create(Trip trip);

        Trip Get(int id);

        Trip GetByReference(string reference);

        List<Trip> GetAll();

        Trip Update(Trip trip);

        void Delete(Trip trip);

        bool ExistById(int id);

        public List<TripDto> GetTripsByDateAndLocation(Location from, Location to, DateTime date);

        public List<TripDto> GetAvailableTrips(Location from, Location to, DateTime date);

        public List<TripDto> GetTripsByDriver(int driverId);

        public List<TripDto> GetInitialisedTrips();
        public List<TripDto> GetTripsByBus(string registrationNumber);

        public List<TripDto> GetTripsByDate(DateTime date);

        public List<TripDto> GetCompletedTrips();


       
    }
}