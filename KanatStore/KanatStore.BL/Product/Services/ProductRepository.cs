using KanatStore.BLL.Generic;
using KanatStore.DAL;
using KanatStore.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanatStore.BLL.Product.Services
{
    public class ProductRepository : IProductRespository
    {
        readonly KanatStoreDBContext _dbContext;
        protected ProductRepository(KanatStoreDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<ProductDetail> GetAll()
        {
            List<ProductDetail> result;

            result = (from products in _dbContext.Products.AsNoTracking()
                      select new ProductDetail
                      {
                          Id = products.Id,
                          Name = products.Name,
                          Category = products.Category

                      }).ToList();
                     

            return result;
        }
    }
}
