using CarRental.Business.Abstract;
using CarRental.DataAccess.Abstract;
using CarRental.Entities.Concrete;
using CarRental.Entities.Dtos;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
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

        public async Task<IDataResult<Car>> AddAsync(Car entity)
        {
            var addedCar = await UnitOfWork.Cars.AddAsync(entity);
            await UnitOfWork.SaveAsync();
            return new SuccessDataResult<Car>(addedCar);
        }

        public async Task<IResult> HardDeleteAsync(Car entity)
        {
            await UnitOfWork.Cars.DeleteAsync(entity);
            await UnitOfWork.SaveAsync();
            return new SuccessResult();
        }

        public async Task<IDataResult<IList<Car>>> GetAllAsync()
        {
            return new SuccessDataResult<IList<Car>>(await UnitOfWork.Cars.GetAllAsync());
        }

        public async Task<IDataResult<Car>> GetByIdAsync(int carId)
        {
            List<Expression<Func<Car, bool>>> predicates = new();
            predicates.Add(x => x.Id == carId);
            var car = await UnitOfWork.Cars.GetAsync(predicates);
            if (car == null)
            {
                new ErrorDataResult<Car>("Verilen parametrede bir araba bulunamadı.");
            }
            return new SuccessDataResult<Car>(car);
        }

        public async Task<IDataResult<IList<CarDetailDto>>> GetCarDetail()
        {
            var carDetails = await UnitOfWork.Cars.GetCarDetail();
            return new SuccessDataResult<IList<CarDetailDto>>(carDetails);
        }

        public async Task<IDataResult<Car>> UpdateAsync(Car entity)
        {
            var updatedCar = await UnitOfWork.Cars.UpdateAsync(entity);
            await UnitOfWork.SaveAsync();
            return new SuccessDataResult<Car>(updatedCar);
        }
    }
}
