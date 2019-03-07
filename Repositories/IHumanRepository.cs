namespace GraphQL_POC_v1.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using GraphQL_POC_v1.Models;

    public interface IHumanRepository
    {
        IObservable<Human> WhenHumanCreated { get; }

        Task<Human> AddHuman(Human human, CancellationToken cancellationToken);

        Task<List<Character>> GetFriends(Human human, CancellationToken cancellationToken);

        Task<Human> GetHuman(Guid id, CancellationToken cancellationToken);
    }
}
