using Jr.Backend.Pedidos.Domain.ValueObject.Pessoa;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Jr.Backend.Pedidos.Domain
{
    public class Pessoa
    {
        [JsonConstructor]
        public Pessoa(string nome, string sobrenome, IList<Endereco> enderecos, string cpf, string rg, string tituloEleitoral)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Sobrenome = sobrenome;
            Enderecos = enderecos;
            Cpf = cpf;
            Rg = rg;
            TituloEleitoral = tituloEleitoral;
        }

        public Guid Id { get; set; }
        public string Nome { get; }
        public string Sobrenome { get; }

        public IList<Endereco> Enderecos { get; }

        public string Cpf { get; }
        public string Rg { get; }
        public string TituloEleitoral { get; }
    }
}