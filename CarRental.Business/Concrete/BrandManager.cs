using CarRental.Business.Abstract;
using CarRental.DataAccess.Abstract;
using CarRental.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Business.Concrete
{
    public class BrandManager : ManagerBase,IBrandService
    {
        public BrandManager(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public async Task<IList<Brand>> GetAllAsync()
        {
            return await UnitOfWork.Brands.GetAllAsync();
        }
    }
}
