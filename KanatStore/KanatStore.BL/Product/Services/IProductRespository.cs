using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KanatStore.DAL.Entities;

namespace KanatStore.BLL.Product.Services
{
    public interface IProductRespository:CommonRepository
    {
        public List<ProductDetail> GetAll();
        public ProductDetail GetById(int id);
        public void Update(ProductDetail pro);
        public void Create(ProductDetail pro);

    }
}
