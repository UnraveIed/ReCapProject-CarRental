using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.DataAccess.Abstract
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        IBrandRepository Brands { get; }
        ICarRepository Cars { get; }
        IColorRepository Colors { get; }
        Task<int> SaveAsync();
    }
}
