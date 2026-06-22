using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCGenericDemoAPPCS_B.Models;

namespace MVCGenericDemoAPPCS_B.Controllers
{
    public class ComputerController : Controller
    {
        private static List<Computer> computers;
        public ComputerController()
        {
            if (computers == null)
            {
                computers = new List<Computer>();
                computers.Add(new Computer { ID = 1, Model = "Dell XPS 13", Processor = "Intel Core i7", RAM = 16, Qty = 10 });
                computers.Add(new Computer { ID = 2, Model = "MacBook Pro", Processor = "Apple M1", RAM = 16, Qty = 5 });
            }
            Console.WriteLine("ComputerController created");
        }
        // GET: ComputerController
        public ActionResult Index()
        {
            Console.WriteLine("Index action called");
            return View(computers.ToList());
        }

        // GET: ComputerController/Details/5
        public ActionResult Details(int id)
        {
            foreach (var computer in computers)
            {
                if (computer.ID == id)
                {
                    return View(computer);
                }
            }
            Console.WriteLine("Detail method called");
            return View();
        }

        // GET: ComputerController/Create
        public ActionResult Create()
        {
            Console.WriteLine("Create GET method called");
            return View();
        }

        // POST: ComputerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Computer newComputer)
        {
            try
            {
                Console.WriteLine("Create POST method called");
                computers.Add(newComputer);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ComputerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ComputerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ComputerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ComputerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
