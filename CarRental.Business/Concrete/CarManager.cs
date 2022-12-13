using CarRental.Business.Abstract;
using CarRental.DataAccess.Abstract;
using CarRental.Entities.Concrete;
using CarRental.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Business.Concrete
{
    public class CarManager : ManagerBase, ICarService
    {
        public CarManager(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public async Task<Car> AddAsync(Car entity)
        {
            var addedCar = await UnitOfWork.Cars.AddAsync(entity);
            await UnitOfWork.SaveAsync();
            return addedCar;
        }

        public async Task DeleteAsync(Car entity)
        {
            await UnitOfWork.Cars.DeleteAsync(entity);
            await UnitOfWork.SaveAsync();
        }

        public Task<IList<Car>> GetAllAsync()
        {
            return UnitOfWork.Cars.GetAllAsync();
        }

        public Task<Car> GetById(int carId)
        {
            List<Expression<Func<Car, bool>>> predicates = new();
            predicates.Add(x => x.Id == carId);
            return UnitOfWork.Cars.GetAsync(predicates);
        }

        public async Task<List<CarDetailDto>> GetCarDetail()
        {
            return await UnitOfWork.Cars.GetCarDetail();
        }

        public async Task<Car> UpdateAsync(Car entity)
        {
            var updatedCar = await UnitOfWork.Cars.UpdateAsync(entity);
            await UnitOfWork.SaveAsync();
            return updatedCar;
        }
    }
}
