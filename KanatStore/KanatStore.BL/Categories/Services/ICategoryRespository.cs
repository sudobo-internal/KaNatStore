using KanatStore.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanatStore.BLL.Categories.Services
{
    public interface ICategoryRespository:CommonRepository
    {
        public List<Category> GetAll();
        public Category GetById(int id);
        public void Create(Category category);
        public bool Update(Category category);
        public bool Delete(int id);
    }
}
