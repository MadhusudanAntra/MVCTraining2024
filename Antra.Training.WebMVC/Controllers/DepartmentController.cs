using Antra.Training.ApplicationCore.Entities;
using Antra.Training.ApplicationCore.RepositoryInterface;
using Microsoft.AspNetCore.Mvc;

namespace Antra.Training.WebMVC.Controllers
{
    public class DepartmentController : Controller
    {
        protected readonly IDepartmentRepository departmentRepository ;
        public DepartmentController(IDepartmentRepository repo)
        {
            departmentRepository = repo;
        }
        public IActionResult Index()
        {
            var content = departmentRepository.GetAll();
            return View(content);

        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Department obj)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    departmentRepository.Insert(obj);
                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    return View(obj);
                }
            }
            return View(obj);
        }
        [HttpGet]
        public IActionResult Delete(int id)
        { 
           var department = departmentRepository.GetById(id);
            return View(department);
        }

        [HttpPost]
        public IActionResult Delete(Department obj)
        {
            departmentRepository.Delete(obj.Id);
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var department = departmentRepository.GetById(id);
            return View(department);
        }

        [HttpPost]
        public IActionResult Edit(Department department)
        {
            try {
            
             departmentRepository.Update(department);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View(department);
            }
        }
    }
}
