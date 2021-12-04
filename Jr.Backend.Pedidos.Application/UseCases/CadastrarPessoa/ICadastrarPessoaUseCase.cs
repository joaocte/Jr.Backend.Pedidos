using Jror.Backend.Message.Events.Pessoa.Events;
using MassTransit;

namespace Jr.Backend.Pedidos.Application.UseCases.CadastrarPessoa
{
    public interface ICadastrarPessoaUseCase : IConsumer<PessoaCadastradaEvent>
    {
    }
}