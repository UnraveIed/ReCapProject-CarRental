using CarRental.Entities.Concrete;
using CarRental.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Business.Abstract
{
    public interface ICarService
    {
        Task<IList<Car>> GetAll();
        Task<CarDetailDto> GetDetailAsync(int carId);
    }
}
