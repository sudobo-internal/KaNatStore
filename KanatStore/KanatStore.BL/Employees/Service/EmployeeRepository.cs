using KanatStore.BLL.Dto;
using KanatStore.BLL.Employees.Service;
using KanatStore.DAL;

namespace KanatStore.BLL.Employee.Service
{
    public class EmployeeRepository:IEmployeeRepository
    {
        private readonly KanatStoreDBContext _dbContext;
        public EmployeeRepository(KanatStoreDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<EmployeeDto> GetAll()
        {
            return (from emp in _dbContext.Employees
                    select new EmployeeDto
                    {
                       Id= emp.Id,
                       FullName= emp.FullName,
                       DOB= emp.DOB,
                       Gender= emp.Gender,
                       Address= emp.Address,
                       ContactNumber= emp.ContactNumber,
                       Identification= emp.Identification,
                       //WorkDays= emp.WorkDays,
                       Bonus= emp.Bonus,
                       Coefficient= emp.Coefficient,
                       Image= emp.Image
                    }).ToList();
        }
        public EmployeeDto GetById(int id)
        {
            bool check = _dbContext.Employees.Any(x=>x.Id == id);
            if(check)
            {
                return (from emp in _dbContext.Employees
                        where emp.Id == id
                        select new EmployeeDto
                        {
                            FullName = emp.FullName,
                            DOB = emp.DOB,
                            Gender = emp.Gender,
                            Address = emp.Address,
                            ContactNumber = emp.ContactNumber,
                            Identification = emp.Identification,
                            //WorkDays = emp.WorkDays,
                            Bonus = emp.Bonus,
                            Coefficient = emp.Coefficient,
                            Image = emp.Image
                        }).FirstOrDefault();
            }
            return null;
        }

        public void Create(EmployeeDto emp)
        {
            DAL.Entities.Employee employee = new DAL.Entities.Employee();
            employee.FullName= emp.FullName;
            employee.DOB= emp.DOB;
            employee.Gender= emp.Gender;    
            employee.Address= emp.Address;
            employee.ContactNumber= emp.ContactNumber;
            employee.Identification= emp.Identification;
            //employee.WorkDays= emp.WorkDays;
            employee.Bonus= emp.Bonus;
            employee.Coefficient = emp.Coefficient;
            employee.Image= emp.Image;
            _dbContext.Employees.Add(employee);
        }
        public bool Edit(EmployeeDto emp)
        {
            var find = _dbContext.Employees.Where(x=>x.Id == emp.Id).FirstOrDefault();
            if (find != null)
            {
                find.FullName = emp.FullName;
                find.DOB= emp.DOB;
                find.Gender= emp.Gender;
                find.Address= emp.Address;
                find.ContactNumber= emp.ContactNumber;
                find.Identification= emp.Identification;
                //find.WorkDays= emp.WorkDays;
                find.Bonus= emp.Bonus;
                find.Coefficient= emp.Coefficient;
                find.Image= emp.Image;
                return true;
            }
            return false;
        }
        public bool Delete(int id)
        {
            var find = _dbContext.Employees.Where(x => x.Id == id).FirstOrDefault();
            if (find != null)
            {
                _dbContext.Employees.Remove(find);
                return true;
            }
            return false;
        }
        public void CheckIn(int id)
        {

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
