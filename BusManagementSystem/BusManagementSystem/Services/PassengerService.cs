using System.Collections.Generic;
using System.Linq;
using BusManagementSystem.DTOS;
using BusManagementSystem.Entities;
using BusManagementSystem.Interfaces.Services;
using BusManagementSystem.Repositories;

namespace BusManagementSystem.Services
{
    public class PassengerService:IPassengerService
    {
         private readonly PassengerRepository _passengerRepository;

        public PassengerService()
        {
            _passengerRepository = new PassengerRepository();
        }
        public bool Create(Passenger passenger)
        {
            var newPassenger = new Passenger
            {
                FullName = $"{passenger.FirstName} {passenger.LastName} {passenger.MiddleName}",
                Address = passenger.Address,
                Email = passenger.Email,
                PhoneNumber = passenger.PhoneNumber,
                Password = passenger.Password

            };
            return true;
        }

        public Passenger Update(Passenger passenger)
        {
            _passengerRepository.Update(passenger);
            return passenger;
        }
        


        public bool Delete(int id, Passenger passenger)
        {
            var check = _passengerRepository.Get(id);
            if (check==null)
            {
                throw new KeyNotFoundException($"The Id {id} cannot be found.");
            }
             _passengerRepository.Delete(id);
             return true;
        }

        Passenger IPassengerService.Get(int id)
        {
            throw new System.NotImplementedException();
        }


        public Passenger Update(string email, string password, Passenger passenger)
        {
            var passengerChecking1 = _passengerRepository.GetByEmail(email);
            
            if (passengerChecking1!=null && _passengerRepository.GetByPassword(password)!=null)
            {
                passengerChecking1.FullName = $"{passenger.FirstName} {passenger.MiddleName} {passenger.LastName}";
                passengerChecking1.Address = passenger.Address;
                passengerChecking1.Email = passenger.Email;
                passengerChecking1.PhoneNumber = passenger.Password;
                passengerChecking1.Password = passenger.Password;

               return _passengerRepository.Update(passengerChecking1);


            }
            else
            {
                throw new KeyNotFoundException($"The Email or Password entered cannot be found.");
            }

           
        }

        public Passenger GetByEmail(string email)
        {
            return _passengerRepository.GetByEmail(email);

        }

        public Passenger GetByPassword(string password)
        {
            return _passengerRepository.GetByPassword(password);
        }
        

        public Passenger Get(int id)
        {
            var passenger = _passengerRepository.Get(id);

            if (passenger==null)
            {
                throw new KeyNotFoundException($"The Passenger with ID number {id} cannot be found.");
            }

            return passenger;
        }

        public bool ExistById(int id)
        {
            var check = _passengerRepository.Get(id);
            if (check==null)
            {
                throw new KeyNotFoundException($"The Passenger with Id number {id} cannot be found");
            }

            return _passengerRepository.ExistById(check.Id);
        }

        public bool ExistByEmail(string email)
        {
            if (ExistByEmail(email))
            {
                return _passengerRepository.ExistByEmail(email);
            }
            else
            {
                throw new KeyNotFoundException($"The Passenger with email {email} does not exist. ");
            }
        }
        

        public List<PassengerDto> GetAll()
        {
           return _passengerRepository.GetAll().Select(passenger => new PassengerDto
           {
               FullName= $"{passenger.FirstName} {passenger.LastName} {passenger.MiddleName}",
               Address = passenger.Address,
               Email = passenger.Email,
               Password = passenger.Password,
               PhoneNumber = passenger.PhoneNumber
                   
               
           }).ToList();
            
        }
    }
}