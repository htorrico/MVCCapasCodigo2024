using Domain;
using Microsoft.AspNetCore.Mvc;
using MVCCapasCodigo2024.Models;
using Services;

namespace MVCCapasCodigo2024.Controllers
{
    public class SchoolsController : Controller
    {
        public IActionResult Index()
        {
            SchoolService service = new SchoolService();

            var schools = service.Get();


            var model = schools.Select(x => new SchoolModel
            {
                SchoolID=x.SchoolID,
                Name = x.Name
            }).ToList();

            return View(model);
        }
        
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Name")] SchoolModel model)
        {

            if (ModelState.IsValid)
            {

                SchoolService service = new SchoolService();
                var dominio = new School
                {

                    Name = model.Name,
                    IsActive = true
                };

                service.Insert(dominio);

                return RedirectToAction(nameof(Index));

            }

            return View(model);
        }
          

        }
}
