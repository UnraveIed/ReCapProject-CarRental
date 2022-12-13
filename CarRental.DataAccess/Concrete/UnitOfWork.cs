using CarRental.DataAccess.Abstract;
using CarRental.DataAccess.Concrete.EntityFramework.Contexts;
using CarRental.DataAccess.Concrete.EntityFramework.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.DataAccess.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CarRentalContext _context;

        public UnitOfWork(CarRentalContext context)
        {
            _context = context;
        }

        private EfBrandRepository _brandRepository;
        private EfCarRepository _carRepository;
        private EfColorRepository _colorRepository;
        public IBrandRepository Brands => _brandRepository ??= new EfBrandRepository(_context);

        public ICarRepository Cars => _carRepository ??= new EfCarRepository(_context);

        public IColorRepository Colors => _colorRepository ??= new EfColorRepository(_context);

        public async ValueTask DisposeAsync()
        {
            await _context.DisposeAsync();
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
