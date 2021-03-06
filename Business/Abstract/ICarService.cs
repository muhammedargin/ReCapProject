﻿using DataAccess.Abstract;
using Entities.Absract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        void Add(Car car);
        void Delete(Car car);
        void Update(Car car);
        List<Car> GetAll();
        Car GetThisCar();
        List<Car> GetCarsByBrandId(int id);
        List<Car> GetCarsByColorId(int id);



    }
}
