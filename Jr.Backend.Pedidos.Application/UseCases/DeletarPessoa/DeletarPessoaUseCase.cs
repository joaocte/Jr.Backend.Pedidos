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

namespace Jr.Backend.Pedidos.Application.UseCases.DeletarPessoa
{
    public class DeletarPessoaUseCase : IDeletarPessoaUseCase
    {
        private readonly IPessoaRepository pessoaRepository;
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;
        public DeletarPessoaUseCase(IPessoaRepository pessoaRepository, IMapper mapper, IUnitOfWork unitOfWork)
        {
            this.pessoaRepository = pessoaRepository;
            this.mapper = mapper;
            this.unitOfWork = unitOfWork; 
        }
        public async Task Consume(ConsumeContext<PessoaDeletadaEvent> context)
        {
            PessoaDeletadaEvent pessoa = context.Message;

            var pessoaEntity = mapper.Map<Infrastructure.Entity.Pessoa>(pessoa);

            await pessoaRepository.RemoveAsync(pessoaEntity);

            await unitOfWork.CommitAsync();
        }
    }
}
