using System.Text.Json.Serialization;

namespace Jr.Backend.Pedidos.Domain.ValueObject.Pedido
{
    public class NumeroPedido
    {
        public string _numeroPedido { get; }

        [JsonConstructor]
        public NumeroPedido(string numeroPedido)
        {
            _numeroPedido = numeroPedido;
        }

        public static implicit operator NumeroPedido(string numeroPedido) => new(numeroPedido);

        public static implicit operator string(NumeroPedido numeroPedido) => numeroPedido;
    }
}