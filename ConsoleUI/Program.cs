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

            //CarGetAll();
            //BrandGetAll();
            //ColorGetAll();

            GetCarDetailsDto();

            Console.WriteLine("Process Completed!!!");

            Console.ReadLine();
        }

        private static void GetCarDetailsDto()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var carDetailsDto in carManager.GetCarDetails().Data)
            {
                Console.WriteLine(carDetailsDto.CarName + " - " + carDetailsDto.BrandName + " - " + carDetailsDto.ColorName);
            }
        }

        private static void ColorGetAll()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var color in colorManager.GetAll().Data)
            {
                Console.WriteLine(color.ColorName);
            }
        }

        private static void BrandGetAll()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            foreach (var brand in brandManager.GetAll().Data)
            {
                Console.WriteLine(brand.BrandName);
            }
        }

        private static void CarGetAll()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetAll().Data)
            {
                Console.WriteLine(car.Id);
            }
        }
    }
}
