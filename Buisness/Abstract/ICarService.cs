using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        void Add(Car car);      
        List<Car> GetAll();
        List<Car> GetCarByBrandId(int brandId);
        List<Car> GetCarByColorId(int colorId);
    }
}
