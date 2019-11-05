using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Persistencia.Repositorio
{
    public interface IRepositorioPrincipal<T>
    {
        T GetById(string id);
        IEnumerable<T> List();
        void Add(T entity);
        void Delete(string id);
        void Edit(T entity);
    }
}
