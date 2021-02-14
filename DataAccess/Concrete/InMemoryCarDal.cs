using DataAccess.Abstract;
using Entities.Absract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        static  List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
              new Car {Id = 1,BrandId = 1,ColorId = 1,ModelYear = 2018,DailyPrice = 249, 
                  Description = "Comfortable and Economical"},
              new Car {Id = 2,BrandId = 2,ColorId = 1,ModelYear = 2015,DailyPrice = 199, 
                  Description = "Car is very economical and has low gasoline consumption "},
              new Car {Id = 3,BrandId = 3,ColorId = 2,ModelYear = 2021,DailyPrice = 399, 
                  Description = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAA"},
               new Car {Id = 4,BrandId = 3,ColorId = 2,ModelYear = 2012,DailyPrice = 99,
                  Description = "BBBBBBBBBBBBBBBBBBBBBBBB"},
                new Car {Id = 5,BrandId = 1,ColorId = 2,ModelYear = 2015,DailyPrice =349,
                  Description = "DDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDD"},
                 new Car {Id = 6,BrandId = 2,ColorId = 2,ModelYear = 2015,DailyPrice =449,
                  Description = "EEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE"},
                  new Car {Id = 7,BrandId = 1,ColorId = 2,ModelYear = 2015,DailyPrice =299,
                  Description = "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF"},
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
            Console.WriteLine("Taşıt Eklendi");
        }

        public void Delete(Car car)
        {
         
            Car carsToDelete = _cars.SingleOrDefault(p => p.Id == car.Id);

            _cars.Remove(carsToDelete);

        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.Id == car.Id);

            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;

        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int Id)
        {
            
            return _cars.Where(p => p.Id == Id).ToList();
        }

        public List<Car> GetByAscPrice()
        {
           
            return _cars.OrderBy(p => p.DailyPrice).ToList();

        }

       public List<Car> GetByDescPrice()
        {
            return _cars.OrderByDescending(p => p.DailyPrice).ToList();
            


        }

        
    }
}
