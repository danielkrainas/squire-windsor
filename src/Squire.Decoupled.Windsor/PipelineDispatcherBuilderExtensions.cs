namespace Squire.Decoupled.Windsor
{
    using Castle.Windsor;
    using CommonServiceLocator.WindsorAdapter;
    using Squire.Decoupled.Commands;
    using Squire.Validation;

    public static class PipelineDispatcherBuilderExtensions
    {
        public static PipelineDispatcherBuilder UseWindsorContainer(this PipelineDispatcherBuilder builder, IWindsorContainer container)
        {
            container.VerifyParam("container").IsNotNull();
            return builder.UseContainer(new WindsorServiceLocator(container));
        }
    }
}
