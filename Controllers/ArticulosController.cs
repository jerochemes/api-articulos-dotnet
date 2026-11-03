using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using TP2BACKEND_DEFINITIVO.DTOs;
using TP2BACKEND_DEFINITIVO.models;
using TP2BACKEND_DEFINITIVO.repositories;

namespace TP2BACKEND_DEFINITIVO.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticulosController : ControllerBase
    {
        private readonly IArticuloRepository _repo;
        private readonly IMapper _mapper;

        public ArticulosController(IArticuloRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ArticuloDTO>> Get()
        {
            var articulos = _repo.GetAll();
            var articulosDto = _mapper.Map<IEnumerable<ArticuloDTO>>(articulos);
            return Ok(articulosDto);
        }

        [HttpGet("{id}")]
        public ActionResult<ArticuloDTO> GetById(int id)
        {
            var articulo = _repo.GetById(id);
            if (articulo == null) return NotFound();

            var articuloDto = _mapper.Map<ArticuloDTO>(articulo);
            return Ok(articuloDto);
        }

        [HttpPost]
        public ActionResult Add([FromBody] ArticuloDTO dto)
        {
            var articulo = _mapper.Map<Articulo>(dto);
            _repo.Add(articulo);
            return Ok();
        }

        [HttpPut("{id}")]
        public ActionResult Update(int id, [FromBody] ArticuloDTO dto)
        {
            var articulo = _mapper.Map<Articulo>(dto);
            articulo.Id = id;
            _repo.Update(articulo);
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _repo.Delete(id);
            return Ok();
        }
    }
}