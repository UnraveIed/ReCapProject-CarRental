﻿using CarRental.Entities.Concrete;
using Core.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Business.Abstract
{
    public interface IRentalService
    {
        Task<IDataResult<IList<Rental>>> GetAllAsync();
        Task<IDataResult<Rental>> GetByIdAsync(int rentalId);
        Task<IDataResult<Rental>> AddAsync(Rental entity);
        Task<IDataResult<Rental>> UpdateAsync(Rental entity);
        Task<IResult> HardDeleteAsync(Rental entity);
    }
}