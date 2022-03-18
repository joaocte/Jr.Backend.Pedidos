using AutoMapper;
using Jr.Backend.Pedidos.Infrastructure.Interfaces;
using Jror.Backend.Libs.Infrastructure.Data.Shared.Interfaces;
using Jror.Backend.Message.Events.Pessoa.Events;
using MassTransit;
using System.Threading.Tasks;

namespace Jr.Backend.Pedidos.Application.UseCases.CadastrarPessoa
{
    public class CadastrarPessoaUseCase : ICadastrarPessoaUseCase
    {
        private readonly IPessoaRepository pessoaRepository;
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public CadastrarPessoaUseCase(IPessoaRepository pessoaRepository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.pessoaRepository = pessoaRepository;
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public async Task Consume(ConsumeContext<PessoaCadastradaEvent> context)
        {
            var pessoa = context.Message as PessoaCadastradaEvent;

            var pessoaEntity = mapper.Map<Infrastructure.Entity.Pessoa>(pessoa);

            await pessoaRepository.AddAsync(pessoaEntity);

            await unitOfWork.CommitAsync();
        }
    }
}