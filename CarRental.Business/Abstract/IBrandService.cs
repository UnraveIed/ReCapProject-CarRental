using CarRental.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Business.Abstract
{
    public interface IBrandService
    {
        Task<IList<Brand>> GetAllAsync();
        Task<Brand> AddAsync(Brand entity);
        Task<Brand> UpdateAsync(Brand entity);
        Task DeleteAsync(Brand entity);
        Task<Brand> GetById(int brandId);
    }
}
