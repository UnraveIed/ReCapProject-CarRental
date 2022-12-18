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
    public class ColorManager : ManagerBase, IColorService
    {
        public ColorManager(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public async Task<IDataResult<Color>> AddAsync(Color entity)
        {
            var addedColor = await UnitOfWork.Colors.AddAsync(entity);
            await UnitOfWork.SaveAsync();
            return new SuccessDataResult<Color>(addedColor);
        }

        public async Task<IResult> HardDeleteAsync(Color entity)
        {
            await UnitOfWork.Colors.DeleteAsync(entity);
            await UnitOfWork.SaveAsync();
            return new SuccessResult();
        }

        public async Task<IDataResult<IList<Color>>> GetAllAsync()
        {
            return new SuccessDataResult<IList<Color>>(await UnitOfWork.Colors.GetAllAsync());
        }

        public async Task<IDataResult<Color>> GetByIdAsync(int colorId)
        {
            var color = await UnitOfWork.Colors.GetAsync(x => x.Id == colorId);
            if (color == null)
            {
                return new ErrorDataResult<Color>("Renk bulunamadı.");
            }
            return new SuccessDataResult<Color>(color);
        }

        public async Task<IDataResult<Color>> UpdateAsync(Color entity)
        {
            var updatedColor = await UnitOfWork.Colors.UpdateAsync(entity);
            await UnitOfWork.SaveAsync();
            return new SuccessDataResult<Color>(updatedColor);
        }
    }
}
