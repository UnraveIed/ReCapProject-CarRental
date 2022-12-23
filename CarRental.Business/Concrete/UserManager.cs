using CarRental.Business.Abstract;
using CarRental.Business.Constants;
using CarRental.Business.ValidationRules.FluentValidation;
using CarRental.DataAccess.Abstract;
using CarRental.DataAccess.Concrete;
using Core.Aspects.Autofac.Validation;
using Core.Entities.Abstract;
using Core.Entities.Concrete;
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
    //public class UserManager : ManagerBase, IUserService
    public class UserManager : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserManager(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<IDataResult<User>> AddAsync(User user)
        {
            var addedUser = await _userRepository.AddAsync(user);
            if (addedUser != null)
            {
                return new SuccessDataResult<User>(addedUser);
            }
            return new ErrorDataResult<User>();
        }

        public async Task<IDataResult<User>> GetByMailAsync(string email)
        {
            var user = await _userRepository.GetAsync(x => x.Email == email);
            if (user != null)
            {
                return new SuccessDataResult<User>(user);
            }
            return new ErrorDataResult<User>();
        }

        public IDataResult<List<OperationClaim>> GetClaims(User user)
        {
            return new SuccessDataResult<List<OperationClaim>>(_userRepository.GetClaims(user));
        }



        #region UnitOfWork
        //public UserManager(IUnitOfWork unitOfWork) : base(unitOfWork)
        //{
        //}

        //public async Task<IDataResult<User>> AddAsync(User entity)
        //{
        //    return new SuccessDataResult<User>(await UnitOfWork.Users.AddAsync(entity), Messages.UserAdded);
        //}

        //public async Task<IResult> HardDeleteAsync(User entity)
        //{
        //    await UnitOfWork.Users.DeleteAsync(entity);
        //    return new SuccessResult(Messages.UserDeleted);
        //}

        //public async Task<IDataResult<IList<User>>> GetAllAsync()
        //{
        //    var list = await UnitOfWork.Users.GetAllAsync();
        //    return new SuccessDataResult<IList<User>>(list, Messages.UserAdded);
        //}

        //public async Task<IDataResult<User>> GetByIdAsync(int userId)
        //{
        //    List<Expression<Func<User, bool>>> predicates = new();
        //    predicates.Add(x => x.Id == userId);
        //    var user = await UnitOfWork.Users.GetAsync(predicates);
        //    if (user == null)
        //    {
        //        return new ErrorDataResult<User>(Messages.UsersNotFound);
        //    }
        //    return new SuccessDataResult<User>(user);
        //}

        //public async Task<IDataResult<User>> UpdateAsync(User entity)
        //{
        //    var updatedUser = await UnitOfWork.Users.UpdateAsync(entity);
        //    return new SuccessDataResult<User>(updatedUser, Messages.UserUpdated);
        //}
        #endregion
    }
}
