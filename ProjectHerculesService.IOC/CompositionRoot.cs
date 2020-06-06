using LightInject;
using ProjectHerculesService.Library.Implementation;
using ProjectHerculesService.Library.Implementation.Builders;
using ProjectHerculesService.Library.Interface;
using ProjectHerculesService.Repository.Implementation;
using ProjectHerculesService.Repository.Interface;

namespace ProjectHerculesService.IOC
{
    public class CompositionRoot : ICompositionRoot
    {
        public void Compose(IServiceRegistry serviceRegistry)
        {
            //IocDependencyRegistry.Bind();

            //System Initializations
            serviceRegistry.Register<IContextContainer, ContextContainer>();

            //Library Initializations

            serviceRegistry.Register<IUserManager, UserManager>();
            serviceRegistry.Register<ISalesTypeManager, SalesTypeManager>();
            serviceRegistry.Register<ISalesTypeBuilder, SalesTypeBuilder>();
            serviceRegistry.Register<ICreateUserRequestBuilder, CreateUserRequestBuilder>();

            //Repository Initializations
            serviceRegistry.Register<IUserRepository, UserRepository>();
            serviceRegistry.Register<ISalesTypeRepository, SalesTypeRepository>();
        }
    }
}
