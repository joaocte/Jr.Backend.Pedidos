using AutoMapper;
using Jr.Backend.Pedidos.Domain.ValueObject.Pessoa;

namespace Jr.Backend.Pedidos.Application.AutoMapper
{
    public class MappingProfileToDomain : Profile
    {
        public MappingProfileToDomain()
        {
            CreateMap<Infrastructure.Entity.Endereco, Endereco>();
            CreateMap<Infrastructure.Entity.Pessoa, Domain.Pessoa>();
        }
    }
}