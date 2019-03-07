namespace GraphQL_POC_v1.Types
{
    using GraphQL_POC_v1.Repositories;

    public class HumanCreatedEvent : HumanObject
    {
        public HumanCreatedEvent(IHumanRepository humanRepository)
            : base(humanRepository)
        {
        }
    }
}
