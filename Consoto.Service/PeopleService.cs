using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Model;
using Contoso.Data;

namespace Consoto.Service
{
    public class PeopleService
    {
        public List<People> GetAllPerson()
        {
            PeopleRepository respository = new PeopleRepository();
            var People = respository.GetAll();
            return respository.GetAll();
        }
        public void SavePerson(People pe)
        {
            PeopleRepository respository = new PeopleRepository();
            respository.CreateNew(pe);

        }
    }
}
