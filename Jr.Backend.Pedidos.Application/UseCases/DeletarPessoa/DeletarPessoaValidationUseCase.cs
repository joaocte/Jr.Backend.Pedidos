using Jr.Backend.Pedidos.Infrastructure.Interfaces;
using Jror.Backend.Message.Events.Pessoa.Events;
using MassTransit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jr.Backend.Pedidos.Application.UseCases.DeletarPessoa
{
    public class DeletarPessoaValidationUseCase : IDeletarPessoaUseCase
    {
        private readonly IPessoaRepository pessoaRepository;
        private readonly IDeletarPessoaUseCase deletarPessoaUseCase;

        public DeletarPessoaValidationUseCase(IPessoaRepository pessoaRepository, IDeletarPessoaUseCase deletarPessoaUseCase)
        {
            this.pessoaRepository = pessoaRepository;
            this.deletarPessoaUseCase = deletarPessoaUseCase;
        }


        public async Task Consume(ConsumeContext<PessoaDeletadaEvent> context)
        {

            var pessoa = context.Message as PessoaDeletadaEvent;

            var pessoaJaCadastrada = await pessoaRepository.ExistsAsync(pessoa.Cpf);

            if (pessoaJaCadastrada)
                return;
             await deletarPessoaUseCase.Consume(context);
        }
    }
}
