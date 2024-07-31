using Alicunde.Domain.Abstractions;
using Alicunde.Domain.Repositories;

namespace Alicunde.Domain.Entities.Fees;

public class FeeDomain
{
    private readonly IFeeRepository _repository;

    public FeeDomain(IFeeRepository repository)
    {
        _repository = repository;
    }

    public async Task<Result<Fee>> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        var feeFound = await _repository.GetByIdAsync(id, cancellationToken);

        if (feeFound is not null)
            return Result.Success(feeFound);

        return Result.Failure<Fee>(Error.EntityNotFound);
    }

    public async Task<Result<IReadOnlyCollection<Fee>>> GetAll(CancellationToken cancellationToken = default)
    {
        var fees = await _repository.GetAll();

        if (fees.Any())
            return Result.Success(fees);

        return Result.Failure<IReadOnlyCollection<Fee>>(Error.EntityNotFound);
    }

    public async Task<Result> Add(Fee feeToAdd, CancellationToken cancellationToken = default)
    {
        await _repository.Add(feeToAdd, cancellationToken);
        return Result.Success();
    }

    public async Task<Result> Update(Fee feeToUpdate, CancellationToken cancellationToken = default)
    {
        await _repository.Update(feeToUpdate, cancellationToken);
        return Result.Success();
    }

    public async Task<Result> Delete(Guid id, CancellationToken cancellationToken = default)
    {
        await _repository.Delete(id, cancellationToken);
        return Result.Success();
    }
}