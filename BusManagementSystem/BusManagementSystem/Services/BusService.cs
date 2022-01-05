using System;
using System.Collections.Generic;
using System.Linq;
using BusManagementSystem.DTOS;
using BusManagementSystem.Entities;
using BusManagementSystem.Enums;
using BusManagementSystem.Interfaces.Services;
using BusManagementSystem.Repositories;
using CreateBusRequestModel = BusManagementSystem.Interfaces.Services.CreateBusRequestModel;
using UpdateBusRequestModel = BusManagementSystem.Interfaces.Services.UpdateBusRequestModel;

namespace BusManagementSystem.Services
{
    public class BusService: IBusService
    {
        private readonly BusRepository _busRepository;
        public int Id { get; set; }
        
        public string Model { get; set; }
        
        public BusType BusType { get; set; }
        
        public string RegistrationNumber { get; set; }
        
        public string PlateNumber { get; set; }
        
        public int Capacity { get; set; }
        
        public bool AvailabilityStatus { get; set; }
        
        public bool TripStatus { get; set; }

        public BusService()
        {
            _busRepository = new BusRepository();
        }
        
         public bool ChangeAvailabilityStatus(string regNumber, bool availabilityStatus)
        {
            var bus = _busRepository.GetByRegistrationNumber(regNumber);
            if (bus == null)
            {
                throw new ($"Bus with Registration Number {regNumber} does not exist");
            }
            bus.AvailabilityStatus = availabilityStatus;
            _busRepository.Update(bus);
            return true;

        }
        

        public bool Delete(string regNumber)
        {
            var bus = _busRepository.GetByRegistrationNumber(regNumber);
            if(bus == null)
            {
                throw new ($"The registration entered{regNumber} does not exist");
            }
            _busRepository.Delete(bus);
            return true;
        }

        public BusDto GetById(int id)
        {
            var bus = _busRepository.Get(id);
            if(bus != null)
            {
                return new BusDto
                {
                    AvailabilityStatus = bus.AvailabilityStatus,
                    BusType = bus.BusType,
                    Capacity = bus.Capacity,
                    Model = bus.Model,
                    PlateNumber = bus.PlateNumber,
                    RegistrationNumber = bus.RegistrationNumber,
                    TripStatus = bus.TripStatus,
                };
            };
            return null;

        }

        public BusDto GetByRegNumber(string RegNumber)
        {
            var bus = _busRepository.GetByRegistrationNumber(RegNumber);
            if(bus == null)
            {
                throw new KeyNotFoundException($"Bus with {RegNumber} not found");
            }
            BusDto busDto = new BusDto
            {
                AvailabilityStatus = bus.AvailabilityStatus,
                BusType = bus.BusType,
                Capacity = bus.Capacity,
                Model = bus.Model,
                PlateNumber = bus.PlateNumber,
                TripStatus = bus.TripStatus,
                Id = bus.Id,
                RegistrationNumber = bus.RegistrationNumber

            };
            return busDto;
        }

        public IList<BusDto> List()
        {
            var buses = _busRepository.GetAll().Select(bus => new BusDto
            {
                AvailabilityStatus = bus.AvailabilityStatus,
                BusType = bus.BusType,
                Capacity = bus.Capacity,
                Model = bus.Model,
                PlateNumber = bus.PlateNumber,
                TripStatus = bus.TripStatus,
                Id = bus.Id,
                RegistrationNumber = bus.RegistrationNumber
            }).ToList();
            return buses;
        }

        public bool Register(CreateBusRequestModel model)
        {
            var bus = new Bus
            {
                AvailabilityStatus = true,
                Capacity = model.Capacity,
                BusType = model.BusType,
                Model = model.Model,
                PlateNumber = model.PlateNumber,
                TripStatus = false,
                RegistrationNumber = Guid.NewGuid().ToString().Substring(0, 11).Replace("-", "").ToUpper(),
            };
            _busRepository.Create(bus);
            return true;
        }

        public bool Update(string regNumber, UpdateBusRequestModel model)
        {
            var bus = _busRepository.GetByRegistrationNumber(regNumber);
            if(bus == null)

            {
                throw new ($"Bus with Registration Number {regNumber} does not exist");
            }
            bus.BusType = model.BusType;
            bus.PlateNumber = model.PlateNumber;
            _busRepository.Update(bus);
            return true;
        }
    }
}