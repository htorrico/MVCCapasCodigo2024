using Microsoft.AspNetCore.Mvc;
using MVCCapasCodigo2024.Models;
using System.Diagnostics;

namespace MVCCapasCodigo2024.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Demo()
        {
            return View();
        }

        public IActionResult Validaciones()
        {
            return View();
        }

        public IActionResult Validaciones2()
        {
            return View();
        }

        public IActionResult DemoAjax()
        {
            return View();
        }

        [HttpPost]
        public JsonResult SubmitForm(string name, string email)
        {
            // Aqu� puedes agregar l�gica para manejar los datos del formulario, como guardarlos en una base de datos
            // Para este ejemplo, simplemente devolvemos un mensaje de �xito

            //return Json(new { message = "Formulario enviado con �xito. Gracias, " + name + "!" });
            return Json(new { message = "Formulario enviado con �xito. Gracias!" });
        }
    }
}
