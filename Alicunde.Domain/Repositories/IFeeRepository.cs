using Alicunde.Domain.Entities.Fees;

namespace Alicunde.Domain.Repositories;

public interface IFeeRepository
{
    Task<Fee?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);

    Task<IReadOnlyCollection<Fee>> GetAll(CancellationToken cancellationToken = default);

    Task Add(Fee feeToAdd, CancellationToken cancellationToken = default);

    Task Update(Fee feeToUpdate, CancellationToken cancellationToken = default);

    Task Delete(Guid id, CancellationToken cancellationToken = default);
}