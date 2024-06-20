using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopApp.DAL.Interfaces;
using ShopApp.DAL.Models.Categories;

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
            var category =this.categoryDb.GetCategoriesById(id);
            return View(category);
        }

        // GET: CategoriesController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoriesController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CategoriesAddModel addModel)
        {
            try
            {
                addModel.creation_date = DateTime.Now;
                addModel.creation_user = 1;
                this.categoryDb.SaveCategory(addModel);

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
            var category = this.categoryDb.GetCategoriesById(id);
            return View(category);
        }

        // POST: CategoriesController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CategoriesUpdateModel updateModel)
        {
            try
            {
                updateModel.ModifyDate = DateTime.Now;
                updateModel.ModifyUser = 1;

                this.categoryDb.UpdateCategory(updateModel);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

    }
}
