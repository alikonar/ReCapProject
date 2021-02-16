using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //AddCarTest();

            ListCarsTest();

        }
        

        

        private static void AddCarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Car car = new Car { BrandId = 4, ColorId = 2, DailyPrice = 30, ModelYear = "1999", Descriptions = "Tofas" };
            carManager.Add(car);
            ListCarsTest();
        }

        private static void ListCarsTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine( car.BrandName + "-" + car.ColorName + "-" + car.DailyPrice);
            }
        }
    }
}
