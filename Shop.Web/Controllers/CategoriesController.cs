using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopApp.DAL.Interfaces;

namespace ShopAPP.Web.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ICategoriesDb categoryDb;

        public CategoriesController(ICategoriesDb categoryDb) 
        {
            this.categoryDb = categoryDb;
        }
        
        // GET: CategoriesController1
        public ActionResult Index()
        {
            var categories = categoryDb.GetCategories();

            return View(categories);
        }

        // GET: CategoriesController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CategoriesController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoriesController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: CategoriesController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CategoriesController1/Edit/5
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

    }
}
