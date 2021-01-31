using System;
using Business.Concrete;
using DataAccess.Concrete;
using Entities.Absract;
using Entities.Concrete;

namespace UIConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            CarManager carManager = new CarManager(new InMemoryCarDal());
            int i = 0;
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("{0}.Araç: {1}",i,car.Description);
                i++;
            }

        }
    }
}
