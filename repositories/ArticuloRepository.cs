using System.Collections.Generic;
using System.Linq;
using TP2BACKEND_DEFINITIVO.models;

namespace TP2BACKEND_DEFINITIVO.repositories
{
    public class ArticuloRepository : IArticuloRepository
    {
        private readonly List<Articulo> _articulos = new();

        public IEnumerable<Articulo> GetAll() => _articulos;

        public Articulo? GetById(int id) => _articulos.FirstOrDefault(a => a.Id == id);

        public void Add(Articulo articulo)
        {
            articulo.Id = _articulos.Count > 0 ? _articulos.Max(a => a.Id) + 1 : 1;
            _articulos.Add(articulo);
        }

        public void Update(Articulo articulo)
        {
            var existente = GetById(articulo.Id);
            if (existente != null)
            {
                existente.Nombre = articulo.Nombre;
                existente.Precio = articulo.Precio;
            }
        }

        public void Delete(int id)
        {
            var articulo = GetById(id);
            if (articulo != null)
                _articulos.Remove(articulo);
        }
    }
}