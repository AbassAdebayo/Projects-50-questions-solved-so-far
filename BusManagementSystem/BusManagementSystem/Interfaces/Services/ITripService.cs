using System;
using System.Collections.Generic;
using BusManagementSystem.DTOS;
using BusManagementSystem.Entities;
using BusManagementSystem.Enums;
using BusManagementSystem.Repositories;

namespace BusManagementSystem.Interfaces.Services
{
    public interface ITripService
    {
        
                bool Schedule(CreateTripRequestModel model);

                Trip Get(int id);

                Trip GetByReference(string reference);

                List<TripDto> GetAll();

                List<TripDto> GetTripsByDate(DateTime date);

                List<TripDto> GetTripsByDateAndLocation(Location from, Location to, DateTime date);

                List<TripDto> GetAvailableTrips(Location from, Location to, DateTime date);

                List<TripDto> GetCancelledTripsByDate(DateTime date);

                List<TripDto> GetCompletedTrips();

                List<TripDto> GetTripsByBus(string registrationNumber);

                List<TripDto> GetTripsByDriver(int driverId);

                List<TripDto> GetInitialisedTrips();

                List<TripDto> GetCancelledTrips();

                bool RescheduleTrip(UpdateBusRequestModel model, string tripReferenceNumber);

                void Delete(string tripReferenceNumber);

                bool UpdateTripStatus(string tripReferenceNumber, TripStatus tripStatus);

    }
}