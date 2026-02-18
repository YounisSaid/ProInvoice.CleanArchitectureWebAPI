namespace ProInvoice.CleanArchitectureWebAPI.Domain.Abstraction
{
    public interface IGenericRepository<TEntity> where TEntity : BaseEntity
    {
        IQueryable<TEntity> GetAll();

        Task<TEntity?> GetByIdAsync
            (Guid id,
             CancellationToken cancellationToken = default);
        Task<TEntity> CreateAsync
            (TEntity entity,
             CancellationToken cancellationToken = default);

        Task CreateRangeAsync(IEnumerable<TEntity> entities,
                              CancellationToken cancellationToken = default);

        TEntity Update(TEntity entity,
                       CancellationToken cancellationToken = default);

        Task UpdateRangeAsync(IEnumerable<TEntity> entities,
                              CancellationToken cancellationToken = default);

        void Delete(TEntity entity,
                       CancellationToken cancellationToken = default);

        Task DeleteRangeAsync(IEnumerable<TEntity> entities,
                              CancellationToken cancellationToken = default);
    }
}
