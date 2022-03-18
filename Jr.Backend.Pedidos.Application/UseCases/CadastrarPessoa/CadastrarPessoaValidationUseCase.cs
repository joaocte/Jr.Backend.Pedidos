using AutoMapper;
using Jr.Backend.Pedidos.Infrastructure.Interfaces;
using Jror.Backend.Libs.Infrastructure.Data.Shared.Interfaces;
using Jror.Backend.Message.Events.Pessoa.Events;
using MassTransit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jr.Backend.Pedidos.Application.UseCases.CadastrarPessoa
{
    public class CadastrarPessoaValidationUseCase : ICadastrarPessoaUseCase
    {
        private readonly IPessoaRepository pessoaRepository;
        private readonly ICadastrarPessoaUseCase cadastrarPessoaUseCase;
        public CadastrarPessoaValidationUseCase(IPessoaRepository pessoaRepository, ICadastrarPessoaUseCase cadastrarPessoaUseCase)
        {
            this.pessoaRepository = pessoaRepository;
            this.cadastrarPessoaUseCase = cadastrarPessoaUseCase;
        }
        public async Task Consume(ConsumeContext<PessoaCadastradaEvent> context)
        {
            var pessoa = context.Message as PessoaCadastradaEvent;

            var pessoaJaCadastrada = await pessoaRepository.ExistsAsync(pessoa.Cpf);

            if (pessoaJaCadastrada)
                return;

             await cadastrarPessoaUseCase.Consume(context);
        }
    }
}
