using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car> {
            new Car{Id =1, BrandId = 1,ColorId = 2,ModelYear = 2016, DailyPrice = 200, Description = "Car 1" },
            new Car{Id =2, BrandId = 2,ColorId = 1,ModelYear = 2017, DailyPrice = 250, Description = "Car 2" },
            new Car{Id =3, BrandId = 2,ColorId = 3,ModelYear = 2018, DailyPrice = 300, Description = "Car 3"},
            new Car{Id =4, BrandId = 3,ColorId = 3,ModelYear = 2014, DailyPrice = 150, Description = "Car 4" },
            }; 
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p=>p.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int carId)
        {
            return _cars.Where(p => p.Id == carId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p=>p.Id == car.Id);
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
