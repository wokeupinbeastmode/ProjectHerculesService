using ProjectHerculesService.IOC.DependencyContainer;
using ProjectHerculesService.Library.Implementation;
using ProjectHerculesService.Library.Implementation.Builders;
using ProjectHerculesService.Library.Interface;
using ProjectHerculesService.Repository.Implementation;
using ProjectHerculesService.Repository.Interface;

namespace ProjectHerculesService.IOC
{
    public class CompositionRoot
    {
        public static void Bind()
        {
            IocDependencyRegistry.Bind();
            //System Initializations
            DependencyContainer.DependencyContainer.Register<IContextContainer, ContextContainer>();
            
            //Library Initializations
           
            DependencyContainer.DependencyContainer.Register<IUserManager, UserManager>();
            DependencyContainer.DependencyContainer.Register<ISalesTypeManager, SalesTypeManager>();
            DependencyContainer.DependencyContainer.Register<ISalesTypeBuilder, SalesTypeBuilder>();
            DependencyContainer.DependencyContainer.Register<ICreateUserRequestBuilder, CreateUserRequestBuilder>();

            //Repository Initializations
            DependencyContainer.DependencyContainer.Register<IUserRepository, UserRepository>();
            DependencyContainer.DependencyContainer.Register<ISalesTypeRepository, SalesTypeRepository>();
        }
    }
}
