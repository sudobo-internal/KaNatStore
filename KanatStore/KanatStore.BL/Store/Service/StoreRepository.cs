using KanatStore.BLL.Dto;
using KanatStore.DAL;
using KanatStore.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanatStore.BLL.Store.Service
{
    public class StoreRepository : IStoreRepository
    {
        private readonly KanatStoreDBContext _dbContext;
        public StoreRepository(KanatStoreDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<StoreDto> GetAll()
        {
            return (from s in _dbContext.Stores
                    select new StoreDto
                    {
                        Id = s.Id,
                        Name = s.Name,
                        Address = s.Address,
                        PhoneNumber= s.PhoneNumber,
                        Email = s.Email
                    }).ToList();
        }
        public StoreDto Get(int id)
        {
            return (from s in _dbContext.Stores
                    where s.Id == id
                    select new StoreDto
                    {
                        Id = s.Id,
                        Name = s.Name,
                        Address = s.Address,
                        PhoneNumber = s.PhoneNumber,
                        Email = s.Email
                    }).FirstOrDefault();
        }
        public void Create(StoreDto store) 
        {
            DAL.Entities.Store addstore = new DAL.Entities.Store();
            addstore.Name = store.Name;
            addstore.Address = store.Address;
            addstore.PhoneNumber = store.PhoneNumber;
            addstore.Email = store.Email;
            _dbContext.Add(addstore);
        }
        public bool Update(StoreDto store)
        {
            var find = _dbContext.Stores.Where(s => s.Id==store.Id);
            if(find!=null)
            {
                var fstore = (from s in _dbContext.Stores
                              where s.Id == store.Id
                              select s).FirstOrDefault();
                fstore.Name = store.Name;
                fstore.Address = store.Address;
                fstore.PhoneNumber = store.PhoneNumber;
                fstore.Email = store.Email;
                return true;
            }
            return false;
        }
        public bool Delete(int id)
        {
            var find = _dbContext.Stores.Where(s => s.Id == id);
            if (find != null)
            {
                var fstore = (from s in _dbContext.Stores
                              where s.Id == id
                              select s).FirstOrDefault();
                _dbContext.Stores.Remove(fstore);
                return true;
            }
            return false;
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
        /// <summary>
        /// Save changes dbcontext
        /// </summary>
        public void Save()
        {
            _dbContext.SaveChanges();
        }

    }
}
