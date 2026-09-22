using Ecom.Core.Interfaces;
using Ecom.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecom.Infrastructure.Repositires
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        public ICategoryRepository CategoryRepository { get; }

        public IProductRepository ProductRepository  { get; }

        public IPhotoRepository photoRepository {  get; }

        public UnitOfWork(AppDbContext context)
        {
            this._context = context;
            CategoryRepository = new CategoryRepository(context);
            ProductRepository = new ProductRepository(context);
            photoRepository = new PhotoRepository(context);
        }
    }
}
