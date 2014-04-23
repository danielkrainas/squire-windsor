namespace Squire.Web.Windsor
{
    using Castle.Windsor;
    using CommonServiceLocator.WindsorAdapter;
    using Squire.Validation;
    using Squire.Web.Mvc;
    using System.Web.Mvc;

    public static class ControllerBuilderExtensions
    {
        public static void UseWindsorContainerFactory(this ControllerBuilder builder, IWindsorContainer container)
        {
            container.VerifyParam("container").IsNotNull();
            builder.SetControllerFactory(new IocControllerFactory(new WindsorServiceLocator(container)));
        }
    }
}
