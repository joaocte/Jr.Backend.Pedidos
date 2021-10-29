using Jr.Backend.Libs.Domain.Abstractions.ValueObject;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Jr.Backend.Pedidos.Domain.ValueObject.Pedido
{
    public class Valor : GenericValueObject
    {
        public decimal _valor;

        [JsonConstructor]
        public Valor(decimal valor)
        {
            _valor = valor;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return _valor;
        }

        public static implicit operator Valor(decimal valor) => new(valor);

        public static implicit operator decimal(Valor valor) => valor;
    }
}