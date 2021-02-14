using System;
using System.Globalization;
using System.Threading;
using Business.Concrete;
using DataAccess.Concrete;
using Entities;
using Entities.Absract;
using Entities.Concrete;

namespace UIConsole
{
    class Program
    {
        static void Main(string[] args)
        {


            CarManager carManager = new CarManager(new InMemoryCarDal());

            
            foreach (var item in carManager.GetAll())
            {
                Console.WriteLine(item.Description);
            }

            carManager.Delete(new Car
            {
                Id = 1,
                BrandId = 1,
                ColorId = 1,
                ModelYear = 2018,
                DailyPrice = 249,
                Description = "Comfortable and Economical"
            });
            Console.WriteLine("---------------------------");
            foreach (var item in carManager.GetAll())
            {
                Console.WriteLine(item.Description);
            }

            Console.WriteLine("---------------------------");

            foreach (var item in carManager.GetByAscPrice())
            {
                Console.WriteLine(item.DailyPrice);
            }
            Console.WriteLine("---------------------------");
            foreach (var item in carManager.GetByDescPrice())
            {
                Console.WriteLine(item.DailyPrice);
            }

        }
        
        

      


        



        
    }


}



