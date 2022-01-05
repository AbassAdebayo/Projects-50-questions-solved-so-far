using System;
using System.Collections.Generic;
using System.Linq;
using BusManagementSystem.DTOS;
using BusManagementSystem.Entities;
using BusManagementSystem.Enums;
using BusManagementSystem.Interfaces.Services;
using BusManagementSystem.Repositories;
using UpdateBusRequestModel = BusManagementSystem.Interfaces.Services.UpdateBusRequestModel;

namespace BusManagementSystem.Services
{
    public class TripService: ITripService
    {
         
        private readonly TripRepository _tripRepository;
        private readonly BusRepository _busRepository;
        private readonly DriverRepository _driverRepository;
        public TripService()
        {
            _busRepository = new BusRepository();
            _tripRepository = new TripRepository();
            _driverRepository = new DriverRepository();
        }

        public void Delete(string tripReferenceNumber)
        {
            var trip = _tripRepository.GetByReference(tripReferenceNumber);
            if ( trip == null) 
            {
                throw new KeyNotFoundException($"The trip reference number {tripReferenceNumber} not found");
            }
            _tripRepository.Delete(trip);
        }

        public Trip Get(int id)
        {
            var check = _tripRepository.Get(id);
            if (check==null)
            {
                throw new KeyNotFoundException($"The trip id {id} is not found");
            }

            return check;
        }

        public List<TripDto> GetAll()
        {
            var Trips = _tripRepository.GetAll().Select(trip => new TripDto
            {
                
                Id = trip.Id,
                DriverId = trip.DriverId,
                DriverFullName = $"{trip.Driver.FirstName} {trip.Driver.LastName}",
                BusId = trip.BusId,
                BusModel = trip.Bus.Model,
                BusRegistrationNumber = trip.Bus.RegistrationNumber,
                AvailableSeat = trip.AvailableSeat,
                LandingPoint = trip.LandingPoint,
                TakeOffPoint = trip.TakeOffPoint,
                TripReference = trip.TripReference,
                TakeOffTime = trip.TakeOffTime,
                LandingTime = trip.LandingTime,
                Status = trip.Status,
                Price = trip.Price,

            }).ToList();
            return Trips;
        }

        public Trip GetByReference(string reference)
        {
            var checkTrip = _tripRepository.GetByReference(reference);
            if (checkTrip==null)
            {
                throw new KeyNotFoundException($"The reference number {reference} does not exist.");
            }

            return _tripRepository.GetByReference(checkTrip.TripReference);
        }

        public List<TripDto> GetCancelledTrips()
        {
            return _tripRepository.GetCancelledTrips();
        }

        public List<TripDto> GetCancelledTripsByDate(DateTime date) => _tripRepository.GetCancelledTripsByDate(date);
        

            public List<TripDto> GetCompletedTrips()
        {
            return _tripRepository.GetCompletedTrips();
        }

        public List<TripDto> GetInitialisedTrips()
        {
            return _tripRepository.GetInitialisedTrips();
        }

        public List<TripDto> GetTripsByBus(string registrationNumber)
        {
            if (_busRepository.ExistByRegNumber(registrationNumber))
            {
                return _tripRepository.GetTripsByBus(registrationNumber);
            }
            else
            {
                throw new KeyNotFoundException($"The Bus Registration Number{registrationNumber} entered does not exist.");
            }
        }

        public List<TripDto> GetTripsByDate(DateTime date)
        {
            return _tripRepository.GetTripsByDate(date);
        }

        public List<TripDto> GetTripsByDateAndLocation(Location from, Location to, DateTime date)
        {
            return _tripRepository.GetTripsByDateAndLocation(from, to, date);
        }

        public List<TripDto> GetTripsByDriver(int driverId)
        {
            var driver = _driverRepository.Get(driverId);
            
            if (driver == null)
            {
                throw new KeyNotFoundException($"The driver Id {driverId} entered does not exist.");
            }
            return _tripRepository.GetTripsByDriver(driver.Id);
            
        }

        public bool Schedule(CreateTripRequestModel model)
        {
            var bus = _busRepository.GetByRegistrationNumber(model.BusRegistrationNumber);
            var driver = _driverRepository.GetByLicenseNumber(model.DriverLicenseNumber);
            var trip = new Trip
            {
                BusId = bus.Id,
                DriverId = driver.Id,
                LandingPoint = model.LandingPoint,
                LandingTime = model.LandingTime,
                TakeOffPoint = model.TakeOffPoint,
                TakeOffTime = model.TakeOffTime,
                AvailableSeat = bus.Capacity,
                TripReference = Guid.NewGuid().ToString().Substring(0, 10).Replace("-", "").ToUpper(),
                Price = model.Price,
                Status = TripStatus.Initialize
                
            };
             _tripRepository.Create(trip);
            return true;
            
        }

        public bool RescheduleTrip(UpdateBusRequestModel model, string tripReferenceNumber)
        {
            var trip = _tripRepository.GetByReference(tripReferenceNumber);
            var bus = _busRepository.GetByRegistrationNumber(model.RegistrationNumber);
            var driver = _driverRepository.GetByLicenseNumber(model.DriverLicense);

            trip.BusId = bus.Id;
            trip.DriverId = driver.Id;
            trip.LandingPoint = model.LandingPoint;
            trip.LandingTime = model.LandingTime;
            trip.TripReference = model.TripReference;
            trip.AvailableSeat = model.AvailableSeat;
            trip.TakeOffTime = model.TakeOffTime;
            trip.TakeOffPoint = model.TakeOffPoint;

            _tripRepository.Update(trip);
            return true;

        }

        public bool UpdateTripStatus(string tripReferenceNumber, TripStatus tripStatus)
        {
           
            var status = _tripRepository.GetByReference(tripReferenceNumber);
            if (status==null)
            {
                throw new KeyNotFoundException(
                    $"The trip status with reference number {tripReferenceNumber} does not exist.");
            }

            if (status.Status == TripStatus.Canceled)
            {
                status.Status = TripStatus.Canceled;
                _tripRepository.Update(status);
                
            }
            else if (status.Status == TripStatus.Completed)
            {
                _tripRepository.Update(status);
                
            }
            else if(status.Status == TripStatus.Initialize)
            {
                _tripRepository.Update(status);
            }
            else if (status.Status == TripStatus.Started)
            {
                _tripRepository.Update(status);
            }
            
            
            return true;
        }

        public List<TripDto> GetAvailableTrips(Location from, Location to, DateTime date)
        {
            return _tripRepository.GetAvailableTrips(from, to, date);
        }
       
    }

   
}