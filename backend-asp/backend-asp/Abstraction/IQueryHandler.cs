using backend_asp.Abstraction.Common;

namespace backend_asp.Abstraction
{
    public interface IQueryHandler<in TQuery, TResponse> where TQuery : IQuery<TResponse>
    {
        Task<Result<TResponse>> ExecuteAsync(TQuery query);
    }
}
