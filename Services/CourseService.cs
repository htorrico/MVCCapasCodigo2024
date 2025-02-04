using Azure.Core.Pipeline;
using Domain;
using Infraestructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
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

        public List<Course> GetFilter(string name)
        {
            using (var contex = new SchoolContext())
            {          
                var query = contex.Courses.Where(
                    x => x.IsActive == true);

                if (!name.IsNullOrEmpty())
                    query = query.Where(x => x.Name.Contains(name));         

                return query.ToList();
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
