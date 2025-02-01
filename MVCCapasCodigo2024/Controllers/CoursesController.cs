using Domain;
using Infraestructure;
using Microsoft.AspNetCore.Mvc;
using MVCCapasCodigo2024.Models;
using Services;

namespace MVCCapasCodigo2024.Controllers
{
    public class CoursesController : Controller
    {
        public IActionResult Index()
        {

            CourseService service = new CourseService();
            
            //Listado de cursos de DOMAIN
            var cursos = service.Get();

            //Dominio a modelo
            //Course = >CourseModel

            var model = cursos.Select(x => new CourseModel
            {
                CourseID = x.CourseID,
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
        public IActionResult Create(CourseModel model)
        {
        
            if (ModelState.IsValid)
            {

                CourseService service = new CourseService();
                //Modelo a Dominio
                //CourseModel = >Course


                var dominio = new Course
                {
                    Name = model.Name,
                    IsActive = true,
                    CreatedOn = DateTime.Now
                };

                service.Insert(dominio);

                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }
    }
}
