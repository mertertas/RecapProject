using Core.EntityFramework;
using DataAcces.Concrete.EntitiyFreamwork;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFreamwork
{
   public class EfCustomerDal:EfEntityFrameworkRepositoryBase<Customer,ReCapContext>,ICustomerDal
    {
    }
}
