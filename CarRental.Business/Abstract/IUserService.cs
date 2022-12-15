using CarRental.Entities.Concrete;
using Core.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Business.Abstract
{
    public interface IUserService
    {
        Task<IDataResult<IList<User>>> GetAllAsync();
        Task<IDataResult<User>> GetByIdAsync(int userId);
        Task<IDataResult<User>> AddAsync(User entity);
        Task<IDataResult<User>> UpdateAsync(User entity);
        Task<IResult> HardDeleteAsync(User entity);
    }
}
