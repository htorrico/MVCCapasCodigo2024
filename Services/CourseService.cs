using Azure.Core.Pipeline;
using Domain;
using Infraestructure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CourseService
    {

        public List<Course> Get()
        {
            using (var contex = new SchoolContext())
            {
                return contex.Courses.Where(x=>x.IsActive==true).ToList();
            }
        }

        public void Insert(Course course) {

            using (var contex = new SchoolContext())
            {
                contex.Courses.Add(course);
                contex.SaveChanges();
            }
        
        
        }

    }
}
