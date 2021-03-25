using Core.EntityFramework;
using DataAcces.Concrete.EntitiyFreamwork;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFreamwork
{
    public class EfRentalDal : EfEntityFrameworkRepositoryBase<Rental, ReCapContext>, IRentalDal
    {
        public List<RentalDetailsDto> GetRentalDetails()
        {
            using (ReCapContext reCapContext = new ReCapContext())
            {
                var result = from r in reCapContext.Rentals join
                                  c in reCapContext.Cars on r.CarId equals c.Id join
                                  m in reCapContext.Customers on r.CustomerId equals m.Id 
                                  
                             select new RentalDetailsDto
                             {
                                 Id=r.Id,
                                 Description=c.Description,
                                 CompanyName=m.CompanyName,
                                 RentDate=r.RentDate,
                                 ReturnDate=r.ReturnDate                                 
                             };

                return result.ToList();
            }   
        }
    }
}
