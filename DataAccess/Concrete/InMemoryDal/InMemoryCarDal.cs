using DataAccess.Abstract;
using Entities.Absract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
              new Car {CarId = 1,BrandId = 1,ColorId = 1,ModelYear = "2018",DailyPrice = 249, 
                  Descriptions = "Comfortable and Economical"},
              new Car {CarId = 2,BrandId = 2,ColorId = 1,ModelYear = "2015",DailyPrice = 199, 
                  Descriptions = "Car is very economical and has low gasoline consumption "},
              new Car {CarId = 3,BrandId = 3,ColorId = 2,ModelYear = "2021",DailyPrice = 399, 
                  Descriptions = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAA"},
               new Car {CarId = 4,BrandId = 3,ColorId = 2,ModelYear = "2012",DailyPrice = 99,
                  Descriptions = "BBBBBBBBBBBBBBBBBBBBBBBB"},
                new Car {CarId = 5,BrandId = 1,ColorId = 2,ModelYear = "2015",DailyPrice =349,
                  Descriptions = "DDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDD"},
                 new Car {CarId = 6,BrandId = 2,ColorId = 2,ModelYear = "2015",DailyPrice =449,
                  Descriptions = "EEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE"},
                  new Car {CarId = 7,BrandId = 1,ColorId = 2,ModelYear = "2015",DailyPrice =299,
                  Descriptions = "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF"},
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
            Console.WriteLine("Taşıt Eklendi");
        }

        public void Delete(Car car)
        {
         
            Car carsToDelete = _cars.SingleOrDefault(p => p.CarId == car.CarId);

            _cars.Remove(carsToDelete);

        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.CarId == car.CarId);

            carToUpdate.CarId = car.CarId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Descriptions = car.Descriptions;

        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int Id)
        {
            
            return _cars.Where(p => p.CarId == Id).ToList();
        }

        public List<Car> GetByAscPrice()
        {
           
            return _cars.OrderBy(p => p.DailyPrice).ToList();

        }

       public List<Car> GetByDescPrice()
        {
            return _cars.OrderByDescending(p => p.DailyPrice).ToList();
            


        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }
    }
}
