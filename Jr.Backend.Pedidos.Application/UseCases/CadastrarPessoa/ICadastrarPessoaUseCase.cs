using Jr.Backend.Message.Events.Pessoa;
using MassTransit;

namespace Jr.Backend.Pedidos.Application.UseCases.CadastrarPessoa
{
    public interface ICadastrarPessoaUseCase : IConsumer<PessoaCadastradaEvent>
    {
    }
}