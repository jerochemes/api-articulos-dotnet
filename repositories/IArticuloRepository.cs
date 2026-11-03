using System.Collections.Generic;
using TP2BACKEND_DEFINITIVO.models;

namespace TP2BACKEND_DEFINITIVO.repositories
{
    public interface IArticuloRepository
    {
        IEnumerable<Articulo> GetAll();
        Articulo? GetById(int id);
        void Add(Articulo articulo);
        void Update(Articulo articulo);
        void Delete(int id);
    }
}
