using CarRental.Business.Abstract;
using CarRental.DataAccess.Abstract;
using CarRental.Entities.Concrete;
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

        public async Task<Brand> AddAsync(Brand entity)
        {
            var addedBrand = await UnitOfWork.Brands.AddAsync(entity);
            await UnitOfWork.SaveAsync();
            return addedBrand;
        }

        public async Task DeleteAsync(Brand entity)
        {
            await UnitOfWork.Brands.DeleteAsync(entity);
            await UnitOfWork.SaveAsync();
        }

        public async Task<IList<Brand>> GetAllAsync()
        {
            return await UnitOfWork.Brands.GetAllAsync();
        }

        public async Task<Brand> GetById(int brandId)
        {
            List<Expression<Func<Brand, bool>>> predi = new();
            predi.Add(x => x.Id == brandId);
            return await UnitOfWork.Brands.GetAsync(predi);
        }

        public async Task<Brand> UpdateAsync(Brand entity)
        {
            var updatedBrand = await UnitOfWork.Brands.UpdateAsync(entity);
            await UnitOfWork.SaveAsync();
            return updatedBrand;
        }
    }
}
