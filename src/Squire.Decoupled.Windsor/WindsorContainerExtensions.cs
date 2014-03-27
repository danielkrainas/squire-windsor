namespace Squire.Decoupled.Windsor
{
    using Castle.MicroKernel.Registration;
    using Castle.Windsor;
    using Squire.Decoupled.Commands;
    using Squire.Decoupled.DomainEvents;
    using Squire.Decoupled.Queries;
    using Squire.Validation;

    public static class WindsorContainerExtensions
    {
        public static IWindsorContainer RegisterCommandHandlersOf(this IWindsorContainer container, FromAssemblyDescriptor from)
        {
            container.VerifyParam("container").IsNotNull();
            from.VerifyParam("from").IsNotNull();
            return container.Register(from.BasedOn(typeof(IHandleCommand<>)).WithServiceFromInterface(typeof(IHandleCommand<>)));
        }

        public static IWindsorContainer RegisterAllCommandHandlers(this IWindsorContainer container)
        {
            container.VerifyParam("container").IsNotNull();
            return container.Register(Classes.FromAssemblyInThisApplication().BasedOn(typeof(IHandleCommand<>)).WithServiceFromInterface(typeof(IHandleCommand<>)));
        }

        public static IWindsorContainer RegisterCommandHandlersIn(this IWindsorContainer container, string assemblyName)
        {
            container.VerifyParam("container").IsNotNull();
            assemblyName.VerifyParam("assemblyName").IsNotBlank();
            return container.Register(Classes.FromAssemblyNamed(assemblyName).BasedOn(typeof(IHandleCommand<>)).WithServiceFromInterface(typeof(IHandleCommand<>)));
        }

        public static IWindsorContainer RegisterDomainEventSubscribersOf(this IWindsorContainer container, FromAssemblyDescriptor from)
        {
            container.VerifyParam("container").IsNotNull();
            from.VerifyParam("from").IsNotNull();
            return container.Register(from.BasedOn(typeof(ISubscribeOn<>)).WithServiceFromInterface(typeof(ISubscribeOn<>)));
        }

        public static IWindsorContainer RegisterAllDomainEventSubscribers(this IWindsorContainer container)
        {
            container.VerifyParam("container").IsNotNull();
            return container.Register(Classes.FromAssemblyInThisApplication().BasedOn(typeof(ISubscribeOn<>)).WithServiceFromInterface(typeof(ISubscribeOn<>)));
        }

        public static IWindsorContainer RegisterDomainEventSubscribersIn(this IWindsorContainer container, string assemblyName)
        {
            container.VerifyParam("container").IsNotNull();
            assemblyName.VerifyParam("assemblyName").IsNotBlank();
            return container.Register(Classes.FromAssemblyNamed(assemblyName).BasedOn(typeof(ISubscribeOn<>)).WithServiceFromInterface(typeof(ISubscribeOn<>)));
        }

        public static IWindsorContainer RegisterQueryExecutorsOf(this IWindsorContainer container, FromAssemblyDescriptor from)
        {
            container.VerifyParam("container").IsNotNull();
            from.VerifyParam("from").IsNotNull();
            return container.Register(from.BasedOn(typeof(IExecuteQuery<,>)).WithServiceFromInterface(typeof(IExecuteQuery<,>)));
        }

        public static IWindsorContainer RegisterAllQueryExecutors(this IWindsorContainer container)
        {
            container.VerifyParam("container").IsNotNull();
            return container.Register(Classes.FromAssemblyInThisApplication().BasedOn(typeof(IExecuteQuery<,>)).WithServiceFromInterface(typeof(IExecuteQuery<,>)));
        }

        public static IWindsorContainer RegisterQueryExecutorsIn(this IWindsorContainer container, string assemblyName)
        {
            container.VerifyParam("container").IsNotNull();
            assemblyName.VerifyParam("assemblyName").IsNotBlank();
            return container.Register(Classes.FromAssemblyNamed(assemblyName).BasedOn(typeof(IExecuteQuery<,>)).WithServiceFromInterface(typeof(IExecuteQuery<,>)));
        }
    }
}
