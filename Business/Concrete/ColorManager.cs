using Business.Abstract;
using Business.Constans;
using Core.Utilities.Results;
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

        public IResult Add(Color color)
        {
            if (color.ColorName.Length<2)
            {
                return new ErrorResult(Messages.CarsNameInValid);
            }
            _colorDal.Add(color);
            return new SuccessResult(Messages.CarAdded);
        }

        public IResult Delete(Color color)
        {
            if (color.ColorName.Length<2)
            {
                return new ErrorResult(Messages.CarsNameInValid);
            }
            _colorDal.Delete(color);
            return new SuccessResult(Messages.CarDeleted);
        }

        public IDataResult<List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll(),Messages.CarsListed);
        }

        public IDataResult<List<Color>> GetById(int colorId)
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll(c => c.ColorId == colorId),Messages.CarsListed);
        }

        public IResult Update(Color color)
        {
            if (color.ColorName.Length<2)
            {
                return new ErrorResult(Messages.CarsNameInValid);
            }
            _colorDal.Update(color);
            return new SuccessResult(Messages.CarUpdated);
        }


    }
}
