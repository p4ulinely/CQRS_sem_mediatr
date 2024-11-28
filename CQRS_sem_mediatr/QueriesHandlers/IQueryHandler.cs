using CQRS_sem_mediatr.Queries;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS_sem_mediatr.QueriesHandlers
{
    public interface IQueryHandler<TQuery, TResponse>
        where TQuery : IQuery<TResponse>
    {
        Task<TResponse> Handle(TQuery query, CancellationToken cancellationToken);
    }
}
