using CarRental.Business.Abstract;
using CarRental.DataAccess.Abstract;
using CarRental.Entities.Concrete;
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
    public class BrandManager : ManagerBase,IBrandService
    {
        public BrandManager(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public async Task<IDataResult<Brand>> AddAsync(Brand entity)
        {
            var addedBrand = await UnitOfWork.Brands.AddAsync(entity);
            await UnitOfWork.SaveAsync();
            return new SuccessDataResult<Brand>(addedBrand);
        }

        public async Task<IResult> HardDeleteAsync(Brand entity)
        {
            await UnitOfWork.Brands.DeleteAsync(entity);
            await UnitOfWork.SaveAsync();
            return new SuccessResult();
        }

        public async Task<IDataResult<IList<Brand>>> GetAllAsync()
        {
            return new SuccessDataResult<IList<Brand>>(await UnitOfWork.Brands.GetAllAsync());
        }

        public async Task<IDataResult<Brand>> GetById(int brandId)
        {
            List<Expression<Func<Brand, bool>>> predi = new();
            predi.Add(x => x.Id == brandId);
            return new SuccessDataResult<Brand>(await UnitOfWork.Brands.GetAsync(predi));
        }

        public async Task<IDataResult<Brand>> UpdateAsync(Brand entity)
        {
            var updatedBrand = await UnitOfWork.Brands.UpdateAsync(entity);
            await UnitOfWork.SaveAsync();
            return new SuccessDataResult<Brand>(updatedBrand);
        }
    }
}
