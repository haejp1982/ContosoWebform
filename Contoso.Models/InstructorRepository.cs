using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Contoso.Model;
using Contoso.Data;

namespace Contoso.Models
{
    public class InstructorRepository : IRepository<Instructor>
    {
        public void Create(Instructor Data)
        {
           
        }

        public void Delete(Instructor Data)
        {
            
        }

        public IEnumerable<Instructor> GetAll()
        {
            return null;
        }

        public Instructor GetBy(int Id)
        {
            return null;
        }

        public void Update(Instructor Data)
        {
            
        }
    }
}
