using CarRental.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Business.Abstract
{
    public interface IColorService
    {
        Task<IList<Color>> GetAll();
    }
}
