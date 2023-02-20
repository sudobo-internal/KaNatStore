using KanatStore.BLL.Employees.Service;
using KanatStore.UI.Models.Employees;
using Microsoft.AspNetCore.Mvc;

namespace KanatStore.UI.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public IActionResult Index()
        {
            EmployeeViewModel employeeViewModel = new EmployeeViewModel();
            employeeViewModel.ListEmp = _employeeRepository.GetAll();
            return View(employeeViewModel);
        }
    }
}
