namespace Squire.Decoupled.Windsor
{
    using Castle.Windsor;
    using CommonServiceLocator.WindsorAdapter;
    using Squire.Decoupled.DomainEvents;
    using Squire.Validation;

    public static class EventPipelineBuilderExtensions
    {
        public static EventPipelineBuilder UseWindsorContainer(this EventPipelineBuilder builder, IWindsorContainer container)
        {
            container.VerifyParam("container").IsNotNull();
            return builder.UseLocator(new WindsorServiceLocator(container));
        }
    }
}
