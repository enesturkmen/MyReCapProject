using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        

        public InMemoryCarDal()
        {
            _cars = new List<Car>() 
            { 
                new Car { CarId = 1, BrandId = 1, ColorId = 1, ModelYear = 2020, DailyPrice = 150, Description = "Available"},
                new Car { CarId = 2, BrandId = 2, ColorId = 2, ModelYear = 2021, DailyPrice = 200, Description = "UnAvailable"},
                new Car { CarId = 3, BrandId = 2, ColorId = 2, ModelYear = 2019, DailyPrice = 125, Description = "Available"},
                new Car { CarId = 4, BrandId = 3, ColorId = 4, ModelYear = 2022, DailyPrice = 250, Description = "UnAvailable"},
                new Car { CarId = 5, BrandId = 4, ColorId = 5, ModelYear = 2021, DailyPrice = 175, Description = "Available"}
            
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(p => p.CarId == id).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p=> p.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            car.Description = car.Description;
        }
    }
}
