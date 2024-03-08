using Antra.Training.ApplicationCore.RepositoryInterface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Antra.Training.WebMVC.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRepository employeeRepository;
        private readonly IDepartmentRepository departmentRepository;

        public EmployeeController(IEmployeeRepository _employeeRepository,IDepartmentRepository departmentRepository)
        {
            this.employeeRepository = _employeeRepository;
            this.departmentRepository = departmentRepository;
        }
        public IActionResult Index()
        {
            ViewBag.Title = "Employee List";
            ViewData["Title"] = "Employee List";
            var result = employeeRepository.GetAll();
            return View(result);
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Departments = new SelectList(departmentRepository.GetAll().Select(x => new { x.Id,x.Name}),"Id","Name");
            return View();
        }


    }
}
