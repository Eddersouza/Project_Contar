using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace ProjectContar.Domain.Contracts.Repositories
{
    /// <summary>
    /// Contract to Base Repository.
    /// </summary>
    public interface BaseRepositoryContract<Entity> : IDisposable
        where Entity : class
    {
        /// <summary>
        /// Create entity in repository.
        /// </summary>
        /// <param name="entity">Object entity to create.</param>
        void Create(Entity entity);

        /// <summary>
        /// Get entities by expression filter.
        /// </summary>
        /// <param name="expressionFilter">Expression filter to  entities result (If null return without expression filter).</param>
        /// <returns>Entity List.</returns>
        IEnumerable<Entity> Get(Expression<Func<Entity, bool>> expressionFilter = null);

        /// <summary>
        /// Get entity by id(s).
        /// </summary>
        /// <param name="ids">Entity id(s) to get.</param>
        /// <returns>Object Entity.</returns>
        Entity Get(object[] ids);
    }
}