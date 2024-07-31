namespace Alicunde.Domain.Abstractions;

public interface IUnitOfWork
{
    #region Private Methods

    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);

    #endregion Private Methods
}