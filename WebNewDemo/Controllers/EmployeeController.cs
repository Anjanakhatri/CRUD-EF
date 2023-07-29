using Microsoft.AspNetCore.Mvc;
using WebNewDemo.Data;
using WebNewDemo.Models;
namespace WebNewDemo.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationContext context;

        public EmployeeController(ApplicationContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            var list = context.Employee.ToList();
          
            return View(list);
        }
        public IActionResult Create()
        {
            return View();

        }
        [HttpPost]
        public IActionResult Create(Employee emp)
        {
            if (ModelState.IsValid)
            {
                var data = new Employee
                {
                    Name =  emp.Name,
                    salary =  emp.salary
                };
                context.Employee.Add(data);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(emp);
            }
        }
        public IActionResult Delete(int id)
        {
            var emp = context.Employee.FirstOrDefault(x => x.Id == id);
            context.Employee.Remove(emp);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            var emp=context.Employee.FirstOrDefault(x=>x.Id==id);
            return View(emp);
        }
        [HttpPost]
        public IActionResult Edit(Employee emp)
        {
            if (ModelState.IsValid)
            { 
                context.Update(emp);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(emp);
            }
        }
    }
}
