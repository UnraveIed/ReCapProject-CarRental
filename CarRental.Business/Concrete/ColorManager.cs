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
    public class ColorManager : ManagerBase, IColorService
    {
        public ColorManager(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public async Task<Color> AddAsync(Color entity)
        {
            var addedColor = await UnitOfWork.Colors.AddAsync(entity);
            await UnitOfWork.SaveAsync();
            return addedColor;
        }

        public async Task DeleteAsync(Color entity)
        {
            await UnitOfWork.Colors.DeleteAsync(entity);
            await UnitOfWork.SaveAsync();
        }

        public async Task<IList<Color>> GetAllAsync()
        {
            return await UnitOfWork.Colors.GetAllAsync();
        }

        public async Task<Color> GetById(int colorId)
        {
            List<Expression<Func<Color, bool>>> predicates = new();
            predicates.Add(x => x.Id == colorId);
            return await UnitOfWork.Colors.GetAsync(predicates);
        }

        public async Task<Color> UpdateAsync(Color entity)
        {
            var updatedColor = await UnitOfWork.Colors.UpdateAsync(entity);
            await UnitOfWork.SaveAsync();
            return updatedColor;
        }
    }
}
