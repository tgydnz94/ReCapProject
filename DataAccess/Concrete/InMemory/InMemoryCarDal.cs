﻿using DataAccess.Abstract;
using Entities.Concrete;
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
                new Car() {Id=1,DailyPrice=200,Description="Ford",ModelYear=1995},
                new Car() {Id=2,DailyPrice=300,Description="Seat",ModelYear=1994},
                new Car() {Id=3,DailyPrice=100,Description="Tofaş",ModelYear=1993}
            };

        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
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

        public List<Car> GetById(int carId)
        {
            return _cars.Where(c=> c.Id==carId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate=_cars.SingleOrDefault(c=> c.Id== car.Id);
            carToUpdate.Id=car.Id;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear=car.ModelYear;
        }
    }
}
