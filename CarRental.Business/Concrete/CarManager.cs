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

        public Task<IList<Car>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<CarDetailDto> GetDetailAsync(int carId)
        {
            List<Expression<Func<Car, bool>>> predicates = new();
            List < Expression < Func<Car, object>>> includes = new();

            predicates.Add(x => x.Id == carId);
            includes.Add(x => x.Brand);
            includes.Add(x => x.Color);

            var selectedCar = await UnitOfWork.Cars.GetAsync(predicates, includes);

            return new CarDetailDto
            {
                CarId = carId,
                BrandName = selectedCar.Brand.Name,
                ColorName = selectedCar.Color.Name,
                DailyPrice = selectedCar.DailyPrice
            };
        }
    }
}
