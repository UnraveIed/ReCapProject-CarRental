using CarRental.Business.Abstract;
using CarRental.Business.Constants;
using CarRental.Business.ValidationRules.FluentValidation;
using CarRental.DataAccess.Abstract;
using CarRental.DataAccess.Concrete;
using CarRental.Entities.Concrete;
using Core.Aspects.Autofac.Validation;
using Core.Entities.Abstract;
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

        [ValidationAspect(typeof(UserValidator))]
        public async Task<IDataResult<User>> AddAsync(User entity)
        {
            var addedUser = await _userRepository.AddAsync(entity);
            return new SuccessDataResult<User>(addedUser, Messages.UserAdded);
        }

        public async Task<IResult> HardDeleteAsync(User entity)
        {
            await _userRepository.DeleteAsync(entity);
            return new SuccessResult(Messages.UserDeleted);
        }

        public async Task<IDataResult<IList<User>>> GetAllAsync()
        {
            var list = await _userRepository.GetAllAsync();
            return new SuccessDataResult<IList<User>>(list, Messages.UserAdded);
        }

        public async Task<IDataResult<User>> GetByIdAsync(int userId)
        {
            List<Expression<Func<User, bool>>> predicates = new();
            predicates.Add(x => x.Id == userId);
            var user = await _userRepository.GetAsync(predicates);
            if (user == null)
            {
                return new ErrorDataResult<User>(Messages.UsersNotFound);
            }
            return new SuccessDataResult<User>(user);
        }

        public async Task<IDataResult<User>> UpdateAsync(User entity)
        {
            var updatedUser = await _userRepository.UpdateAsync(entity);
            return new SuccessDataResult<User>(updatedUser, Messages.UserUpdated);
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
