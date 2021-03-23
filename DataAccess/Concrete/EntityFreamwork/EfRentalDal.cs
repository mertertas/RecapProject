using Core.EntityFramework;
using DataAcces.Concrete.EntitiyFreamwork;
using DataAccess.Abstract;
using Entities.Concrete;
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
              
    }
}
