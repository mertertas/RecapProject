using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataAcces.Abstract;
using Entities.Concrete;

namespace DataAcces.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        private List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1,BrandId = 2,ColorId = 3,DailyPrice = 50000,ModelYear = 1997,Description = "BMV"},
                new Car{Id=2,BrandId = 3,ColorId = 7,DailyPrice = 95000,ModelYear = 2005,Description = "FORD"},
                new Car{Id=3,BrandId = 3,ColorId = 16,DailyPrice = 150000,ModelYear = 2010,Description = "FIAT"}
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carDelete = _cars.SingleOrDefault(p => p.Id == car.Id);
            _cars.Remove(carDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public Car GetAll(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int Id)
        {
           return _cars.Where(p => p.Id == Id).ToList();
           
        }

        public List<Car> GetById(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carUpdate = _cars.SingleOrDefault(p => p.Id == car.Id);

            carUpdate.ColorId = car.ColorId;
            carUpdate.BrandId = car.BrandId;
            carUpdate.DailyPrice = car.DailyPrice;
            carUpdate.ModelYear = car.ModelYear;
            carUpdate.Description = car.Description;

        }

        List<Car> IEntityRepository<Car>.GetAll(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
