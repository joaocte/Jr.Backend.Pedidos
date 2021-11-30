using AutoMapper;
using Jr.Backend.Message.Events.Pessoa.Evemts;
using Jr.Backend.Pedidos.Domain.ValueObject.Pessoa;

namespace Jr.Backend.Pedidos.Application.AutoMapper
{
    public class MappingProfileToEntity : Profile
    {
        public MappingProfileToEntity()
        {
            CreateMap<Endereco, Infrastructure.Entity.Endereco>();
            CreateMap<Documentos, Infrastructure.Entity.Documentos>();
            CreateMap<NomeCompleto, Infrastructure.Entity.NomeCompleto>();
            CreateMap<Domain.Pessoa, Infrastructure.Entity.Pessoa>();

            CreateMap<Message.Share.Pessoa.Endereco, Infrastructure.Entity.Endereco>();
            CreateMap<Message.Share.Pessoa.Documentos, Infrastructure.Entity.Documentos>();
            CreateMap<Message.Share.Pessoa.NomeCompleto, Infrastructure.Entity.NomeCompleto>();
            CreateMap<PessoaCadastradaEvent, Infrastructure.Entity.Pessoa>();
        }
    }
}