using Microsoft.AspNetCore.Mvc;
using MVCCapasCodigo2024.Models;
using Services;

namespace MVCCapasCodigo2024.Controllers
{
    public class SchoolsAjaxController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Get()
        {

            SchoolService service = new SchoolService();

            //Listado de cursos de DOMAIN
            var schools = service.Get();

            var model = schools.Select(x => new SchoolModel
            {
                SchoolID = x.SchoolID,
                Name = x.Name
            }).ToList();


            return Json(model);
        }

        [HttpPost]
        public JsonResult Create(string name)
        {

            try
            {
                var service = new SchoolService();
                service.Insert(new Domain.School { Name = name, IsActive = true });

                return Json(new { message = "Escuela registrada Correctamente" });
            }
            catch (Exception)
            {

                return Json(new { message = "Error, comunicarse con el adminstrador" });
            }
           
        }

    }
}
