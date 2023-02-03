using KanatStore.DAL;
using KanatStore.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanatStore.BLL.Categories.Services
{
    public class CategoryRespository : ICategoryRespository
    {
        protected readonly KanatStoreDBContext _dbContext;
        public CategoryRespository(KanatStoreDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<Category> GetAll()
        {
            return _dbContext.Categories.ToList();
        }
    }
}
