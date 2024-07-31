using Alicunde.Domain.Entities.Fees;
using Alicunde.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Alicunde.Infraestructure.Repositories
{
    internal class FeeRepository : Repository<Fee>, IFeeRepository
    {
        public FeeRepository(AlicundeDbContext dbContext) : base(dbContext)
        {
        }

        public async Task Add(Fee feeToAdd, CancellationToken cancellationToken = default)
        {
            await DbContext.AddAsync(feeToAdd, cancellationToken);
        }

        public async Task Delete(Guid id, CancellationToken cancellationToken = default)
        {
            var feeToBeDeleted = await GetByIdAsync(id);
            if (feeToBeDeleted is not null)
                DbContext.Fees.Remove(feeToBeDeleted);
        }

        public async Task<IReadOnlyCollection<Fee>> GetAll(CancellationToken cancellationToken = default)
        {
            return await DbContext.Fees.ToListAsync();
        }

        public async Task Update(Fee feeToUpdate, CancellationToken cancellationToken = default)
        {
            var feeToBeUpdated = await GetByIdAsync(feeToUpdate.Id);

            if (feeToBeUpdated is not null)
                DbContext.Fees.Update(feeToUpdate);
        }
    }
}