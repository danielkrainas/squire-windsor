namespace Squire.Mongo.Windsor
{
    using Castle.MicroKernel.Registration;
    using Castle.Windsor;

    public static class WindsorContainerExtensions
    {
        public static IWindsorContainer RegisterMongo<TMongoContext>(this IWindsorContainer container)
            where TMongoContext : IMongoContext
        {
            return container.Register(Component.For<IMongoContext>().ImplementedBy<TMongoContext>());
        }
    }
}
