using KanatStore.DAL;
using KanatStore.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanatStore.BLL.Product.Services
{
    public class ProductRepository : IProductRespository
    {
        protected readonly KanatStoreDBContext _dbContext;
        public ProductRepository(KanatStoreDBContext dbContext) 
        {
            _dbContext = dbContext;
        }

        public List<ProductDetail> GetAll()
        {
            return _dbContext.Products.Include(x=>x.Category).ToList();
        }

        public ProductDetail GetById(int id)
        {
            return _dbContext.Products.Where(x => x.Id == id).FirstOrDefault();
        }
    }
}
