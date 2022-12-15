using CarRental.Business.Abstract;
using CarRental.DataAccess.Abstract;
using CarRental.Entities.Concrete;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Business.Concrete
{
    public class RentalManager : ManagerBase, IRentalService
    {
        public RentalManager(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public async Task<IDataResult<Rental>> AddAsync(Rental entity)
        {
            var carStatus = await UnitOfWork.Rentals.AnyAsync(x => x.CarId == entity.CarId && x.ReturnDate == null);
            if (carStatus)
            {
                return new ErrorDataResult<Rental>("Araç aktif kirada.");
            }
            await UnitOfWork.Rentals.AddAsync(entity);
            await UnitOfWork.SaveAsync();
            return new SuccessDataResult<Rental>();
        }

        public async Task<IResult> HardDeleteAsync(Rental entity)
        {
            var carStatus = await UnitOfWork.Rentals.AnyAsync(x=>x.Id == entity.Id && x.ReturnDate == null);
            if (carStatus)
            {
                return new ErrorResult("Araç aktif kirada.");
            }
            await UnitOfWork.Rentals.DeleteAsync(entity);
            await UnitOfWork.SaveAsync();
            return new SuccessResult();
        }

        public async Task<IDataResult<IList<Rental>>> GetAllAsync()
        {
            return new SuccessDataResult<IList<Rental>>(await UnitOfWork.Rentals.GetAllAsync());
        }

        public async Task<IDataResult<Rental>> GetByIdAsync(int rentalId)
        {
            var rental = await UnitOfWork.Rentals.GetAsync(x=>x.Id==rentalId);
            if (rental == null)
            {
                return new ErrorDataResult<Rental>("Verilen parametrede bir kira bulunamadı.");
            }
            return new SuccessDataResult<Rental>(rental);
        }

        public async Task<IDataResult<Rental>> UpdateAsync(Rental entity)
        {
            var rental = await UnitOfWork.Rentals.GetAsync(x => x.Id == entity.Id);
            if (rental == null)
            {
                return new ErrorDataResult<Rental>("Verilen parametrede bir kira bulunamadı.");
            }
            var updatedRental = await UnitOfWork.Rentals.UpdateAsync(entity);
            await UnitOfWork.SaveAsync();
            return new SuccessDataResult<Rental>(updatedRental);
        }
    }
}
