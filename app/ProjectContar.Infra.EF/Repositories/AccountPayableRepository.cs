using ProjectContar.Domain.Contracts.Repositories;
using ProjectContar.Domain.Entities;
using ProjectContar.Infra.EF.Contexts;

namespace ProjectContar.Infra.EF.Repositories
{
    public class AccountPayableRepository
        : BaseRepository<AccountPayable>,
        AccountPayableRepositoryContract
    {
        public AccountPayableRepository(ContarDBMSSQL context)
            : base(context)
        {
        }
    }
}