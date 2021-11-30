using System.Text.Json.Serialization;

namespace Jr.Backend.Pedidos.Domain.ValueObject.Pessoa
{
    public class Documentos
    {
        public string Cpf { get; }
        public string Rg { get; }
        public string TituloEleitoral { get; }

        [JsonConstructor]
        public Documentos(string cpf, string rg, string tituloEleitoral)
        {
            Cpf = cpf;
            Rg = rg;
            TituloEleitoral = tituloEleitoral;
        }

        public Documentos(string cpf)
        {
            Cpf = cpf;
        }

        public Documentos(string cpf, string rg) : this(cpf)
        {
            Rg = rg;
        }
    }
}