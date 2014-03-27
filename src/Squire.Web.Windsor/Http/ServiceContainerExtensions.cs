namespace Squire.Reticulated.Windsor.Http
{
    using Castle.Windsor;
    using CommonServiceLocator.WindsorAdapter;
    using Squire.Validation;
    using System.Web.Http.Controllers;

    public static class ServiceContainerExtensions
    {
        public static void UseWindsorContainerActivator(this ServicesContainer services, IWindsorContainer container)
        {
            container.VerifyParam("container").IsNotNull();
            Squire.Web.Http.ServiceContainerExtensions.UseContainerActivator(services, new WindsorServiceLocator(container));
        }
    }
}
