using Jr.Backend.Message.Events.Pessoa.Evemts;
using MassTransit;

namespace Jr.Backend.Pedidos.Application.UseCases.CadastrarPessoa
{
    public interface ICadastrarPessoaUseCase : IConsumer<PessoaCadastradaEvent>
    {
    }
}