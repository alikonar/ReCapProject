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
            //CarManagerTest();
            //BrandManagerTest();
            ColorManagerTest();


            void ColorManagerTest()
            {
                ColorManager color = new ColorManager(new EfColorDal());
                var result = color.GetAll();
                if (result.Success)
                {
                    foreach (var colors in result.Data)
                    {
                        Console.WriteLine(colors.ColorId);
                        Console.WriteLine(colors.ColorName);

                    }
                    Console.WriteLine(result.Message);
                }
                else
                {
                    Console.WriteLine(result.Message);
                }
            }


            void BrandManagerTest()
            {
                BrandManager brandManager = new BrandManager(new EfBrandDal());
                var result = brandManager.GetAll();
                if (result.Success)
                {
                    foreach (var brand in result.Data)
                    {
                        Console.WriteLine(brand.BrandId);
                        Console.WriteLine(brand.BrandName);
                    }
                    Console.WriteLine(result.Message);
                         
                }
                else
                {
                    Console.WriteLine(result.Message);
                }
            }

              void CarManagerTest()
            {    
                    CarManager carManager = new CarManager(new EfCarDal());
                    var result = carManager.GetAll();
                    if (result.Success)
                    {
                        foreach (var car in result.Data)
                        {
                            Console.WriteLine(car.Descriptions);
                            Console.WriteLine(car.ColorId);

                        }
                        Console.WriteLine(result.Message);

                    }
                    else
                    {
                        Console.WriteLine(result.Message);
                    }
            }
            
        }
       
    }
}
