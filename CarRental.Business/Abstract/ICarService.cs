﻿using CarRental.Entities.Concrete;
using CarRental.Entities.Dtos;
using Core.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Business.Abstract
{
    public interface ICarService
    {
        Task<IDataResult<IList<Car>>> GetAllAsync();
        Task<IDataResult<IList<CarDetailDto>>> GetCarDetail();
        Task<IDataResult<Car>> AddAsync(Car entity);
        Task<IDataResult<Car>> UpdateAsync(Car entity);
        Task<IResult> HardDeleteAsync(Car entity);
        Task<IDataResult<Car>> GetById(int carId);
    }
}
