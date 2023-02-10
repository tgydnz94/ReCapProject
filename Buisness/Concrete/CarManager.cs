using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if (car.DailyPrice>0 && car.Description.Length>2)
            {
                _carDal.Add(car);
            }
            else
            {
                new Exception("Araba ismi minimum 2 karakter ve günlük ücret sıfırdan büyük olmalıdır.");
            }
        }

        

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetCarByBrandId(int brandId)
        {
            return _carDal.GetAll(p=> p.BrandId == brandId);
        }

        public List<Car> GetCarByColorId(int colorId)
        {
           return _carDal.GetAll(p=> p.ColorId== colorId);
        }

    }
}
