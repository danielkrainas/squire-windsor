namespace Squire.Web.Windsor
{
    using Castle.MicroKernel.Registration;
    using Castle.Windsor;
    using Squire.Validation;
    using Squire.Web;
    using System.Web.Mvc;

    public static class WindsorContainerExtensions
    {
        public static IWindsorContainer RegisterAllControllersOf(this IWindsorContainer container, FromAssemblyDescriptor from)
        {
            container.VerifyParam("container").IsNotNull();
            from.VerifyParam("from").IsNotNull();
            return container.Register(from.BasedOn<IController>().LifestyleTransient());
        }

        public static IWindsorContainer RegisterAllControllers(this IWindsorContainer container)
        {
            container.VerifyParam("container").IsNotNull();
            return container.Register(Classes.FromAssemblyInThisApplication().BasedOn<IController>().LifestyleTransient());
        }

        public static IWindsorContainer RegisterDefaultHttpContextProvider(this IWindsorContainer container)
        {
            container.VerifyParam("container").IsNotNull();
            return container.Register(Component.For<IHttpContextProvider>().ImplementedBy<DefaultHttpContextProvider>());
        }
    }
}
