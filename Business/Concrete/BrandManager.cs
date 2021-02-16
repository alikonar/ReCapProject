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
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public IResult Add(Brand brand)
        {
            if (brand.BrandName.Length<2)
            {
                return new ErrorResult(Messages.CarsNameInValid);

            }
            _brandDal.Add(brand);
            return new SuccessResult(Messages.CarAdded);
        }

        public IResult Delete(Brand brand)
        {
            if (brand.BrandName.Length<2)
            {
                return new ErrorResult(Messages.CarsNameInValid);

            }
            _brandDal.Delete(brand);
            return new SuccessResult(Messages.CarDeleted);
        }

        public IDataResult<List<Brand>> GetAll()
        {

            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(),Messages.CarsListed);
        }

        public IDataResult<List<Brand>> GetById(int brandId)
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(b => b.BrandId == brandId),Messages.CarsListed);
        }

        public IResult Update(Brand brand)
        {
            if (brand.BrandName.Length<2)
            {
                return new ErrorResult(Messages.CarsNameInValid);

            }
            _brandDal.Update(brand);
            return new SuccessResult(Messages.CarUpdated);
        }
    }
}
