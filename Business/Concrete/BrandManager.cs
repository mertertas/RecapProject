using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAcces.Abstract;
using DataAcces.Concrete.EntitiyFreamwork;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            _brandDal.Add(brand);

            return new SuccesResult(Messages.BrandAdded);
        }

        public IResult Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            return new SuccesResult(Messages.BrandDeleted);
        }

        public SuccessDataResult<List<Brand>> GetAll()
        {
          return new SuccessDataResult<List<Brand>>(_brandDal.GetAll());
        }

        public SuccessDataResult<List<Brand>> GetById(int brandId)
        {
            return  new SuccessDataResult<List<Brand>>( _brandDal.GetAll(p=>p.Id==brandId));
        }

        public IResult Update(Brand brand)
        {
            _brandDal.Update(brand);

            return new SuccesResult(Messages.BrandUpdated);
        }
    }
}
