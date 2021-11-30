﻿using AutoMapper;
using Jr.Backend.Message.Events.Pessoa.Evemts;
using Jr.Backend.Message.Share.Pessoa;

namespace Jr.Backend.Pedidos.Application.AutoMapper
{
    public class MappingProfileToEnvent : Profile
    {
        public MappingProfileToEnvent()
        {
            CreateMap<Infrastructure.Entity.Endereco, Endereco>();
            CreateMap<Infrastructure.Entity.Documentos, Documentos>();
            CreateMap<Infrastructure.Entity.NomeCompleto, NomeCompleto>();
            CreateMap<Infrastructure.Entity.Pessoa, PessoaCadastradaEvent>();
        }
    }
}