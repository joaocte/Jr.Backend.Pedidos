using Jr.Backend.Libs.Domain.Abstractions.ValueObject;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Jr.Backend.Pedidos.Domain.ValueObject.Pedido
{
    public class NumeroPedido : GenericValueObject
    {
        public string _numeroPedido { get; }

        [JsonConstructor]
        public NumeroPedido(string numeroPedido)
        {
            _numeroPedido = numeroPedido;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return _numeroPedido;
        }

        public static implicit operator NumeroPedido(string numeroPedido) => new(numeroPedido);

        public static implicit operator string(NumeroPedido numeroPedido) => numeroPedido;
    }
}