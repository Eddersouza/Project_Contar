using ProjectContar.App;
using ProjectContar.Domain.Contracts.App;
using ProjectContar.Domain.Contracts.Repositories;
using ProjectContar.Infra.EF.Contexts;
using ProjectContar.Infra.EF.Repositories;
using SimpleInjector;

namespace ProjectContar.IoC
{
    /// <summary>
    /// Dependency Injection module.
    /// </summary>
    public class DIModule
    {
        /// Inicializa IoC.
        /// </summary>
        /// <param name="container">Objeto com dados das interfaes/classses que serão usadas.</param>
        /// <param name="lifestyle">Lifestyle que será usado.</param>
        public static void InitializeIoc(Container container, Lifestyle lifestyle)
        {
            //// App
            container.Register<AccountPayableAppContract, AccountPayableApp>(lifestyle);

            //// Service

            //// Repository

            //// Mailing

            // Domain

            //// Base
            container.Register<AccountPayableRepositoryContract, AccountPayableRepository>(lifestyle);
            container.Register(typeof(BaseRepositoryContract<>), typeof(BaseRepository<>), lifestyle);
            container.Register<ContarDBMSSQL>(lifestyle);
            container.Verify();
        }
    }
}