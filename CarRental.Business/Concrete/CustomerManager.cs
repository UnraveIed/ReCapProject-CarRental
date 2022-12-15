using CarRental.Business.Abstract;
using CarRental.DataAccess.Abstract;
using CarRental.Entities.Concrete;
using Core.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Business.Concrete
{
    public class CustomerManager : ManagerBase, ICustomerService
    {
        public CustomerManager(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public Task<IDataResult<Customer>> AddAsync(Customer entity)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> HardDeleteAsync(Customer entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<IList<Customer>>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<Customer>> GetByIdAsync(int customerId)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<Customer>> UpdateAsync(Customer entity)
        {
            throw new NotImplementedException();
        }
    }
}
