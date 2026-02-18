namespace ProInvoice.CleanArchitectureWebAPI.Domain.Abstraction
{
    public interface IUnitOfWork
    {
        Task<string> CommitAsync(CancellationToken cancellationToken = default,
                                 bool checkForCounccerncy = false);

        IGenericRepository<TEntity> Repository<TEntity>()
            where TEntity : BaseEntity;

    }
}
