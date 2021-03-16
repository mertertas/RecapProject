using Core.EntityFramework;
using DataAcces.Abstract;
using Entities.Concrete;
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
        
    }
}
