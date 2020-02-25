using Agenda.Data;
using Agenda.Domain.Contracts.Repositories;
using Agenda.InfraStructure.Repositories;
using Unity;
using Unity.Lifetime;

namespace Agenda.StartUp
{
    public static class DependencyResolver
    {
        public static void Resolve(UnityContainer container)
        {
            container.RegisterType<AppDataContext, AppDataContext>(new HierarchicalLifetimeManager());
            container.RegisterType<IUserRepository, UserRepository>(new HierarchicalLifetimeManager());
        }
    }
}
