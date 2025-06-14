using BulkyWebAppFinal.Data;
using BulkyWebAppFinal.Models;
using Microsoft.AspNetCore.Mvc;

namespace BulkyWebAppFinal.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
         public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Category> objCategoryList = _db.Categories.ToList();
            return View(objCategoryList);
        }
         
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Category obj)
        {
            //checked the name if is it match the displayoder number that will be showing error message 

            if (obj.Name == obj.DisplayOrder.ToString())
            {
                ModelState.AddModelError("Name", "The Display Order cannot exactly match the Name.");
            }
            //if(obj.Name.ToLower() == "test")
            //{
            //    ModelState.AddModelError("", "Test is an invalid value");
            //}
            //checked it can be required my fullfill condiiton
            if (ModelState.IsValid)
            {  
                _db.Categories.Add(obj);
                _db.SaveChanges();
                 return RedirectToAction("Index");
            }
            return View(obj);
        }
    }
}
 