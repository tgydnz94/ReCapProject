using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }
        public void Add(Color color)
        {
            if(color !=null) _colorDal.Add(color);
            
        }

        public void Delete(Color color)
        {
            //_colorDal.Delete(color);
            if(color !=null) _colorDal.Delete(color);
        }

        public List<Color> GetAll()
        {
            return _colorDal.GetAll();
        }

        public List<Color> GetByColorId(int colorId)
        {
            return _colorDal.GetAll(p=> p.ColorId == colorId);
        }

        public void Update(Color color)
        {
            _colorDal.Update(color);
        }
    }
}
