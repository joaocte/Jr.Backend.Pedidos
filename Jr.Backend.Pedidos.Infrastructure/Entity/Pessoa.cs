﻿using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace Jr.Backend.Pedidos.Infrastructure.Entity
{
    public class Pessoa
    {
        public Pessoa()
        {
            Id = Guid.NewGuid().ToString();
        }

        [BsonId]
        public string Id { get; set; }

        public NomeCompleto NomeCompleto { get; set; }

        public IList<Endereco> Enderecos { get; set; }

        public Documentos Documentos { get; set; }
    }
}