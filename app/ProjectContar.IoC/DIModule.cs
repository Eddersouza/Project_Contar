using ProjectContar.App;
using ProjectContar.Domain.Contracts.App;
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
            // container.Register<UnitOfWorkContrato, UnitOfWork>(lifestyle);
            // container.Register(typeof(BaseRepositoryContract<>), typeof(BaseRepository<>), lifestyle);
            // container.Register<DECONDB2Context>(lifestyle);
            container.Verify();
        }
    }
}