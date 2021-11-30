using System.Text.Json.Serialization;

namespace Jr.Backend.Pedidos.Domain.ValueObject.Pedido
{
    public class Valor
    {
        public decimal _valor;

        [JsonConstructor]
        public Valor(decimal valor)
        {
            _valor = valor;
        }

        public static implicit operator Valor(decimal valor) => new(valor);

        public static implicit operator decimal(Valor valor) => valor;
    }
}