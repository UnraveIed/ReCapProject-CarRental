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
    public class ColorManager : ManagerBase, IColorService
    {
        public ColorManager(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public Task<IList<Color>> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
