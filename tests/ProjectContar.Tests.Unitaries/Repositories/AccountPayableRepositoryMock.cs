using Moq;
using ProjectContar.Domain.Contracts.Repositories;
using ProjectContar.Domain.Entities;
using System.Collections.Generic;

namespace ProjectContar.Tests.Unitaries.Repositories
{
    /// <summary>
    /// Account Payable Repository Mock.
    /// </summary>
    internal class AccountPayableRepositoryMock
    {
        /// <summary>
        /// Create Mock Repository.
        /// </summary>
        /// <param name="Accounts">Accounts list to simule the db.</param>
        /// <returns>Object Mock to Account Payable Repository.</returns>
        public Mock<AccountPayableRepositoryContract> CreateRepository(IList<AccountPayable> Accounts)
        {
            Mock<AccountPayableRepositoryContract> mockAccountRepository =
                           new Mock<AccountPayableRepositoryContract>();

            mockAccountRepository
                .Setup(ma => ma.Create(It.IsAny<AccountPayable>()))
                .Callback((AccountPayable entity) =>
                {
                    Accounts.Add(entity);
                });

            mockAccountRepository
               .Setup(ma => ma.SaveChanges())
               .Returns(() =>
               {
                   return true;
               });

            return mockAccountRepository;
        }
    }
}