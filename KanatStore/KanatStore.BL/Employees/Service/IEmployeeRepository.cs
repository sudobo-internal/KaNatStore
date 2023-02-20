using KanatStore.BLL.Dto;

namespace KanatStore.BLL.Employees.Service
{
    /// <summary>
    /// include methods to manage employees
    /// </summary>
    public interface IEmployeeRepository:CommonRepository
    {
        /// <summary>
        /// get all employees
        /// </summary>
        /// <returns>list employees</returns>
        public List<EmployeeDto> GetAll();
        /// <summary>
        /// Get employee by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Employee</returns>
        public EmployeeDto GetById(int id);
        /// <summary>
        /// create a new employee
        /// </summary>
        /// <param name="employee"></param>
        /// <returns>true/false</returns>
        public void Create (EmployeeDto employee);
        /// <summary>
        /// update information employee
        /// </summary>
        /// <param name="emp">employee want to change</param>
        /// <returns>true/false</returns>
        public bool Edit (EmployeeDto emp);
        /// <summary>
        /// Delete a employee by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>true/false</returns>
        public bool Delete (int id);
        /// <summary>
        /// Check employee in/out
        /// </summary>
        /// <param name="id">id of employee</param>
        public void CheckIn(int id);
    }
}
