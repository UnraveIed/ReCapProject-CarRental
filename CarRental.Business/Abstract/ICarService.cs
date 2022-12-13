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
        Task<IList<Car>> GetAllAsync();
        Task<List<CarDetailDto>> GetCarDetail();
        Task<Car> AddAsync(Car entity);
        Task<Car> UpdateAsync(Car entity);
        Task DeleteAsync(Car entity);
        Task<Car> GetById(int carId);
    }
}
