using KanatStore.BLL.Dto;
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
        /// <summary>
        /// Create a new product
        /// </summary>
        /// <param name="pro"></param>
        public void Create(ProductDto pro)
        {
            //_dbContext.Products.Add(pro);
            //pro.CategoryName = (from p in _dbContext.Products
            //                   join c in _dbContext.Categories
            //                   on p.CategoryId equals c.Id
            //                   select c.Name).FirstOrDefault();
            DAL.Entities.Product product = new DAL.Entities.Product();
            product.Name = pro.Name;
            product.Length = pro.Length;
            product.Width= pro.Width;
            product.Thickness= pro.Thickness;
            product.Origin = pro.Origin;
            product.Image = pro.Image;
            product.Price= pro.Price;
            product.ImportPrice= pro.ImportPrice;
            product.Quantity= pro.Quantity;
            product.Unit = pro.Unit;
            product.Status= pro.Status;
            product.Description= pro.Description;
            product.CategoryId= pro.CategoryId;
            _dbContext.Products.Add(product);
        }
        /// <summary>
        /// Get all products
        /// </summary>
        /// <returns>List Products</returns>
        public List<ProductDto> GetAll()
        {
            //return _dbContext.Products.Include(x=>x.Category).ToList();
            return (from p in _dbContext.Products
                    join c in _dbContext.Categories
                    on p.CategoryId equals c.Id
                    select new ProductDto
                    {
                        Id= p.Id,
                        Name= p.Name,
                        Length = p.Length,
                        Width= p.Width,
                        Thickness= p.Thickness,
                        Origin= p.Origin,
                        Image= p.Image,
                        Price= p.Price,
                        ImportPrice= p.ImportPrice,
                        Quantity= p.Quantity,
                        Unit = p.Unit,  
                        Status= p.Status,
                        Description= p.Description,
                        CategoryId= p.CategoryId,
                        CategoryName = c.Name
                    }).ToList();
        }
        /// <summary>
        /// Get a product by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>product</returns>
        public ProductDto GetById(int id)
        {
            //return _dbContext.Products.Where(x => x.Id == id).Include(x => x.Category).FirstOrDefault();
            return (from p in _dbContext.Products
                    join c in _dbContext.Categories
                    on p.CategoryId equals c.Id
                    where p.Id == id
                    select new ProductDto
                    {
                        Id = p.Id,
                        Name = p.Name,
                        Length = p.Length,
                        Width = p.Width,
                        Thickness = p.Thickness,
                        Origin = p.Origin,
                        Image = p.Image,
                        Price = p.Price,
                        ImportPrice = p.ImportPrice,
                        Quantity = p.Quantity,
                        Unit = p.Unit,
                        Status = p.Status,
                        Description = p.Description,
                        CategoryId = p.CategoryId,
                        CategoryName = c.Name
                    }).FirstOrDefault();
        }

        //public void Update(ProductDto pro)
        //{
        //    _dbContext.Products.Update(pro);
        //}

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
        /// <summary>
        /// Save changes dbcontext
        /// </summary>
        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
