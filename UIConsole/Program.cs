using System;
using System.Globalization;
using System.Threading;
using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities;
using Entities.Absract;
using Entities.Concrete;

namespace UIConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var item in carManager.GetAll())
            {
                Console.WriteLine(item.Descriptions);
            }
            carManager.Add(new Car
            {
                //niye 1002 oluyor ??
                BrandId = 2,
                ColorId = 3,
                ModelYear = "2011",
                DailyPrice = 9999,
                Descriptions = "yeni eklediğim"
            });

            Console.WriteLine("------------------------------");

            carManager.Delete(new Car
            {
                CarId=2002,//niye 1002 VB oluyor ??
                BrandId = 2,
                ColorId = 3,
                ModelYear = "2011",
                DailyPrice = 9999,
                Descriptions = "yeni eklediğim"
            });

            Console.WriteLine( "---------------------------" );

            foreach (var item in carManager.GetAll())
            {
                Console.WriteLine(item.Descriptions);
            }

        }
        
        

      


        



        
    }


}



