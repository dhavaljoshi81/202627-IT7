using Microsoft.AspNetCore.Mvc;

namespace TestDemoMVCCoreWebAPP.Controllers
{
    public enum EmployeeType
    {
        VicePresident = 1,
        Manager,
        Officer,
        Peon
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public EmployeeType Type { get; set; }
        public int Salary { get; set; }
    }

    public class EmployeeSearchCriteria
    {
        public string? Name { get; set; }
        public EmployeeType? Type { get; set; }
        public int? MinSalary { get; set; }
        public int? MaxSalary { get; set; }
    }
    public class PMTestController : Controller
    {
        private static List<Employee> employees = new List<Employee>();

        public PMTestController()
        {
            if (employees.Count == 0)
            {
                employees.Add(new Employee { Id = 1, Name = "Ram Kumar", Type = EmployeeType.VicePresident, Salary = 100000 });
                employees.Add(new Employee { Id = 2, Name = "Pavan Pujara", Type = EmployeeType.Manager, Salary = 80000 });
                employees.Add(new Employee { Id = 3, Name = "Jatin Dhawan", Type = EmployeeType.Officer, Salary = 50000 });
                employees.Add(new Employee { Id = 4, Name = "Balkiran", Type = EmployeeType.Peon, Salary = 20000 });
            }
        }

        public IActionResult Index()
        {
            return View(employees);
        }

        [HttpGet]
        public IActionResult SearchIndex(EmployeeSearchCriteria criteria)
        {
            var filteredEmployees = employees.Where(emp => IsMatch(emp, criteria)).ToList();

            // Pass the criteria back to the view to persist form values
            ViewBag.Criteria = criteria;
            return View(filteredEmployees);
        }

        // Advanced Search using Pattern Matching
        private static bool IsMatch(Employee emp, EmployeeSearchCriteria criteria)
        {
            return criteria switch
            {
                // 1. If criteria is null, everything matches
                null => true,

                // 2. Extract properties and apply relational patterns
                { Name: var name, Type: var type, MinSalary: var min, MaxSalary: var max } =>
                    (string.IsNullOrEmpty(name) || 
                           emp.Name.Contains(name, StringComparison.OrdinalIgnoreCase)) &&
                    (type is null || emp.Type == type) &&
                    (min is null || emp.Salary >= min) &&
                    (max is null || emp.Salary <= max)
            };
        }
    }
}
