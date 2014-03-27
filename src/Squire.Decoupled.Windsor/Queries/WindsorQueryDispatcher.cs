namespace Squire.Decoupled.Windsor.Queries
{
    using Castle.Windsor;
    using CommonServiceLocator.WindsorAdapter;
    using Squire.Decoupled.Queries;

    public class WindsorQueryDispatcher : IocQueryDispatcher
    {
        public WindsorQueryDispatcher(IWindsorContainer container)
            : base(new WindsorServiceLocator(container))
        {
        }
    }
}
