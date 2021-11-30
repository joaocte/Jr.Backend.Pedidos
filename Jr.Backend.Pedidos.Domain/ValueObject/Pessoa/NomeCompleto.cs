using System.Text.Json.Serialization;

namespace Jr.Backend.Pedidos.Domain.ValueObject.Pessoa
{
    public class NomeCompleto
    {
        public string Nome { get; }
        public string Sobrenome { get; }

        [JsonConstructor]
        public NomeCompleto(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        public NomeCompleto(string nome)
        {
            Nome = nome;
        }

        public static implicit operator NomeCompleto(string nomeCompleto) => new(nomeCompleto);

        public static implicit operator string(NomeCompleto nomeCompleto) => nomeCompleto;
    }
}