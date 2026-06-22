using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCGenericDemoAPPCS.Models;

namespace MVCGenericDemoAPPCS.Controllers
{
    public class ProductsController : Controller
    {
        private static List<Product> products;// = new List<Product>();
        public ProductsController()
        {
            if (products == null)
            {
                products = new List<Product>();
                products.Add(new Product { ID = 1, Name = "Laptop", Rate = 50000, Qty = 10 });
                products.Add(new Product { ID = 2, Name = "Desktop", Rate = 62000, Qty = 20 });
            }          
            Console.WriteLine("Controller");
        }
        // GET: ProductsController
        public ActionResult Index()
        {
            Console.WriteLine("Index");
            return View(products.ToList());
        }

        // GET: ProductsController/Details/5
        public ActionResult Details(int id)
        {
            foreach (var item in products)
            {
                if (item.ID == id)
                {
                    return View(item);
                }
            }
            Console.WriteLine("Detail");
            return View();
        }

        // GET: ProductsController/Create
        public ActionResult Create()
        {
            Console.WriteLine("Create Get");
            return View();
        }

        // POST: ProductsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product newProduct)
        {
            try
            {
                Console.WriteLine("Create Post");
                products.Add(newProduct);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProductsController/Edit/5
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

        // GET: ProductsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductsController/Delete/5
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
