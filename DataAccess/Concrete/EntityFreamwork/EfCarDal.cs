using Core.EntityFramework;
using DataAcces.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Concrete.EntitiyFreamwork
{
    public class EfCarDal : EfEntityFrameworkRepositoryBase<Car, ReCapContext>, ICarDal
    {
        public List<CarDetailsDto> GetCarDetails()
        {
            using (ReCapContext reCapContext = new ReCapContext())
            {
                var result =from c in reCapContext.Cars join
                                 r in reCapContext.Colors on c.ColorId equals r.Id join
                                 m in reCapContext.Brands on c.BrandId equals m.Id
                            select new CarDetailsDto
                            {
                                BrandName=m.BrandName,
                                CarName=c.Description,
                                DailyPrice=c.DailyPrice,
                                ColorName=r.ColorName
                            };

                return result.ToList();
            }
           
        }
    }
}
