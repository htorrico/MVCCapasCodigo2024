﻿using Infraestructure;
using Microsoft.AspNetCore.Mvc;

namespace MVCCapasCodigo2024.Controllers
{
    public class StudentAjaxController : Controller
    {
        //private readonly SchoolContext _context;

        //public StudentAjaxController(SchoolContext context)
        //{
        //    //_context = context;
        //}
        // Muestra la lista de estudiantes
        public IActionResult Index()
        {
            //var students = _context.Students.ToList();
            //return View(students);
            return View(null);
        }

        //Todo con AJAX
        public IActionResult Index2()
        {

            return View();
        }

        // Acción para abrir el modal de crear estudiante
        public IActionResult CreateStudent()
        {
            return PartialView("_CreateStudentPartial");
        }

        [HttpPost]
        public async Task<IActionResult> SubmitForm(string firstName, string lastName)
        {
            //var student = new Student
            //{
            //    FirstName = firstName,
            //    LastName = lastName,
            //    DocumentNumber = "00000000" // Puedes modificar esto según necesites
            //};

            //_context.Students.Add(student);
            //await _context.SaveChangesAsync();

            return Json(new { message = "Estudiante registrado con éxito." });
        }

        [HttpGet] // Decorador para manejar solicitudes GET
        public IActionResult GetStudents()
        {
            //var students = _context.Students.ToList();
            //return Json(students);
            return Json(null);
        }
    }
}
