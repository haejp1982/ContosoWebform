using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Models
{
    public interface IRepository<T>
    {
        void Create(T Data);
        IEnumerable<T> GetAll();
        T GetBy(int Id);
        void Update(T Data);
        void Delete(T Data);
    }
}
