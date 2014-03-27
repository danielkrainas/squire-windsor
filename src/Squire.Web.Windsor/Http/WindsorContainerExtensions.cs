namespace Squire.Reticulated.Windsor.Http
{
    using Castle.MicroKernel.Registration;
    using Castle.Windsor;
    using Squire.Validation;
    using System.Web.Http.Controllers;

    public static class WindsorContainerExtensions
    {
        public static IWindsorContainer RegisterAllApiControllersIn(this IWindsorContainer container, FromAssemblyDescriptor from)
        {
            container.VerifyParam("container").IsNotNull();
            from.VerifyParam("from").IsNotNull();
            return container.Register(from.BasedOn<IHttpController>().LifestyleTransient());
        }

        public static IWindsorContainer RegisterAllApiControllers(this IWindsorContainer container)
        {
            container.VerifyParam("container").IsNotNull();
            return container.Register(Classes.FromAssemblyInThisApplication().BasedOn<IHttpController>().LifestyleTransient());
        }
    }
}
