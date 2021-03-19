﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAcces.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if (car.Description.Length<=2 && car.DailyPrice>0)
            {
                _carDal.Add(car);
            }
            else Console.WriteLine("Kayıt Eklenemedi.");
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public List<Car> GetAll()
        {
           return  _carDal.GetAll();
        }

        public List<CarDetailsDto> GetCarDetails()
        {
           return _carDal.GetCarDetails();
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            return _carDal.GetAll(p=>p.BrandId== brandId);
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
            return _carDal.GetAll(p=>p.ColorId==colorId);
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }

       
    }
}
