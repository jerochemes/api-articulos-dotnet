using AutoMapper;
using TP2BACKEND_DEFINITIVO.DTOs;
using TP2BACKEND_DEFINITIVO.models;

namespace TP2BACKEND_DEFINITIVO.mapper
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ArticuloDTO, Articulo>();
                config.CreateMap<Articulo, ArticuloDTO>();
            });

            return mappingConfig;
        }
    }
}