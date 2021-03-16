using Business.Concrete;
using DataAcces.Concrete.EntitiyFreamwork;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Recap Project Start =>>>");

            CarManager carManager = new CarManager(new EfCarDal());

            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.Id);
            //}



            //carManager.Add(new Car { BrandId = 3, ColorId = 2, DailyPrice = 1000, Description = "RENAULT", ModelYear = 1997 });
            //carManager.Delete(new Car{Id = 2});
            //carManager.Update(new Car{Id= 3,Description = "ABC"});



            Console.ReadLine();
        }
    }
}
