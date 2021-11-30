using System.Text.Json.Serialization;

namespace Jr.Backend.Pedidos.Domain.ValueObject.Pessoa
{
    public class Endereco
    {
        public string Logradouro { get; }
        public string Bairro { get; }
        public string Numero { get; }
        public string Estado { get; }
        public string Cidade { get; }
        public string Pais { get; }
        public string Cep { get; }

        public string Complemento { get; }

        [JsonConstructor]
        public Endereco(string logradouro, string bairro, string numero, string estado, string cidade, string pais, string cep, string complemento)
        {
            Logradouro = logradouro;
            Bairro = bairro;
            Numero = numero;
            Estado = estado;
            Cidade = cidade;
            Pais = pais;
            Cep = cep;
            Complemento = complemento;
        }

        public static implicit operator string(Endereco endereco) => endereco.ToString();

        public override string ToString()
        {
            return $"Logradouro: {Logradouro} Número: {Numero}, Bairro: {Bairro}, Cep: {Cep}, Cidade: {Cidade}, Estado: {Estado}, País: {Pais}";
        }
    }
}