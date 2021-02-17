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


            Console.WriteLine("------------------------------");

            foreach (var item in carManager.GetCarsByBrandId(1))
            {
                Console.WriteLine(item.Descriptions+" : "+item.BrandId);
            }


        }
        
        

      


        



        
    }


}



