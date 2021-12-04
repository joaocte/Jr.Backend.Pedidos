using AutoMapper;
using Jr.Backend.Pedidos.Domain.ValueObject.Pessoa;
using Jror.Backend.Message.Events.Pessoa.Events;

namespace Jr.Backend.Pedidos.Application.AutoMapper
{
    public class MappingProfileToEntity : Profile
    {
        public MappingProfileToEntity()
        {
            CreateMap<Endereco, Infrastructure.Entity.Endereco>();
            CreateMap<Domain.Pessoa, Infrastructure.Entity.Pessoa>();

            CreateMap<Jror.Backend.Message.Share.Pessoa.Endereco, Infrastructure.Entity.Endereco>();
            CreateMap<PessoaCadastradaEvent, Infrastructure.Entity.Pessoa>();
        }
    }
}