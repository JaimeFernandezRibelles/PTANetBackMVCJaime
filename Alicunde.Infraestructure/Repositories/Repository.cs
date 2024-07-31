using Alicunde.Domain.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace Alicunde.Infraestructure.Repositories
{
    internal abstract class Repository<T>
        where T : Entity
    {
        #region Protected Fields

        protected readonly AlicundeDbContext DbContext;

        #endregion Protected Fields

        #region Protected Constructors

        protected Repository(AlicundeDbContext context)
        {
            DbContext = context;
        }

        public async Task<T?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
        {
            return await DbContext.Set<T>().FirstOrDefaultAsync(entity => entity.Id == id, cancellationToken);
        }

        #endregion Protected Constructors
    }
}