using Jror.Backend.Message.Events.Pessoa.Events;
using MassTransit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jr.Backend.Pedidos.Application.UseCases.DeletarPessoa
{
    public interface IDeletarPessoaUseCase : IConsumer<PessoaDeletadaEvent>
    {
    }
}
