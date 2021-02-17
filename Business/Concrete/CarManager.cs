using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if (car.DailyPrice>0 && car.BrandId>0 && car.Descriptions.Length>15)
            {
                _carDal.Add(car);
            }
            else
            {
                Console.WriteLine("Kurallara uyulmadığından araç eklenemedi.");
            }
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public Car GetThisCar(Car car)
        {
            return _carDal.Get();
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll(p=> p.BrandId == id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.GetAll(p =>p.ColorId==id);
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }

        public Car GetThisCar()
        {
            throw new NotImplementedException();
        }
    }
}
