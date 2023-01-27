using KanatStore.BLL.Product.Services;
using KanatStore.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanatStore.BLL.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly KanatStoreDBContext _dbContext;
        public IProductRespository Product { get; }

        public UnitOfWork(KanatStoreDBContext dbContext, IProductRespository product)
        {
            _dbContext = dbContext;
            Product = product;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _dbContext.Dispose();
            }
        }
        public int Save()
        {
            return _dbContext.SaveChanges();
        }
    }
}
