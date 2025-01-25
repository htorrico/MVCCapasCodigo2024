using Domain;
using Infraestructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class SchoolService
    {
        public List<School> Get()
        {
            using (var contex = new SchoolContext())
            {
                return contex.Schools.Where(x=>x.IsActive==true).ToList();
            }
        }

        public void Insert(School school)
        {

            using (var contex = new SchoolContext())
            {
                contex.Schools.Add(school);
                contex.SaveChanges();
            }


        }
    }
}
