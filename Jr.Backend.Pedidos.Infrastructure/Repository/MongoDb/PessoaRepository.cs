using Jr.Backend.Pedidos.Infrastructure.Interfaces;
using Jror.Backend.Libs.Infrastructure.MongoDB.Abstractions.Interfaces;
using Jror.Backend.Libs.Infrastructure.MongoDB.Repository;

namespace Jr.Backend.Pedidos.Infrastructure.Repository.MongoDb
{
    public class PessoaRepository : MongoRepository<Entity.Pessoa>, IPessoaRepository
    {
        public PessoaRepository(IMongoContext context, string collectionName) : base(context, collectionName)
        {
        }
    }
}