using Microsoft.AspNetCore.Mvc;
using RecordTypeDemoMVCWebAPPCS7A.Models;

namespace RecordTypeDemoMVCWebAPPCS7A.Controllers
{
    public class EmployeeController : Controller
    {
        private List<Employee> employees;
        public EmployeeController()
        {
            if (employees == null)
            {
                employees = new List<Employee>();
                employees.Add(new Employee { ID = 1, Name = "Rohit", Age = 30, Designation = "Software Engineer", City = "Surat" });
                employees.Add(new Employee { ID = 2, Name = "Jayesh", Age = 35, Designation = "Developer", City = "Vadodara" });
                employees.Add(new Employee { ID = 3, Name = "Romit", Age = 32, Designation = "Designer", City = "Rajkot" });
                employees.Add(new Employee { ID = 4, Name = "Umesh", Age = 40, Designation = "Project Manager", City = "Surat" });

            }
        }
        public IActionResult Index()
        {
            var employeeList = employees.Select(e => e);
            return View(employeeList.ToList());
        }

        public IActionResult RecordIndex()
        {
            var employeeList = employees
                    .Select(e => new EmpR(e.Name, e.Age, e.Designation));


            return View(employeeList.ToList());
        }

        public IActionResult StructIndex()
        {
            var employeeList = employees
                    .Select(e => new EmpStruct
                    {
                        Name = e.Name,
                        Age = e.Age,
                        Designation = e.Designation
                    });


            return View(employeeList.ToList());
        }

        public IActionResult AnonIndex()
        {
            var employeeList = employees
                    .Select(e => new 
                    {
                        name = e.Name,
                        age = e.Age,
                        designation = e.Designation
                    });


            return View(employeeList.ToList());
        }
    }
}
