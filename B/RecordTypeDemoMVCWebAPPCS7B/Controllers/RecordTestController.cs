using Microsoft.AspNetCore.Mvc;
using RecordTypeDemoMVCWebAPPCS7B.Models;

namespace RecordTypeDemoMVCWebAPPCS7B.Controllers
{

    public class RecordTestController : Controller
    {
        private static List<Student> students;

        public RecordTestController()
        {
            if (students == null)
            {
                students = new List<Student>();
                students.Add(new Student 
                { id = 1, name = "Rajesh", age = 30, 
                    city = "Surat", semester = 9 });
                students.Add(new Student 
                { id = 2, name = "Kiran", age = 26, 
                    city = "Rajkot", semester = 8 });
                students.Add(new Student 
                { id = 3, name = "Ranjan", age = 26, 
                    city = "Ahmedabad", semester = 9 });
            }
            
        }

        public IActionResult Index()
        {
            return View(students.ToList());
        }

        public IActionResult RecordIndex()
        {
            var result = students
                .Select(s => new Stud(s.name, s.age, s.city));

            return View(result.ToList());
        }

        public IActionResult StructIndex()
        {
            var result = students
                .Select(s => new StructStudent 
                    { Name = s.name, Age = s.age, City = s.city });

            return View(result.ToList());
        }

        public IActionResult AnonIndex()
        {
            var result = students
                .Select(
                s => new
                {
                    Name = s.name,
                    Age = s.age,
                    City = s.city
                }
                );

            return View(result.ToList());
        }
    }
}
