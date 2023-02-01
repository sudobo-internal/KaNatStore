using KanatStore.DAL;
using KanatStore.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanatStore.BLL.Product.Services
{
    public class ProductRepository : CommonRepository,IProductRespository
    {
        protected readonly KanatStoreDBContext _dbContext;
        public ProductRepository(KanatStoreDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Create(ProductDetail pro)
        {
            //var name = _dbContext.Products.SingleOrDefault(p => p.Name == pro.Name);
            //if(name != null)
            //{

            //}
            _dbContext.Products.Add(pro);
        }

        public List<ProductDetail> GetAll()
        {
            return _dbContext.Products.Include(x=>x.Category).ToList();
        }

        public ProductDetail GetById(int id)
        {
            return _dbContext.Products.Where(x => x.Id == id).Include(x=>x.Category).FirstOrDefault();
        }

        public void Update(ProductDetail pro)
        {
            _dbContext.Products.Update(pro);
        }

        private bool _disposed = false;
        protected virtual void Dispose(bool disposed)
        {
            if (!_disposed)
            {
                if (disposed)
                {
                    _dbContext.Dispose();
                }
            }
            this._disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
