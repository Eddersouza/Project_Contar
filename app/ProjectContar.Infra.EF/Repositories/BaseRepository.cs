using ProjectContar.Domain.Contracts.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace ProjectContar.Infra.EF.Repositories
{
    /// <summary>
    /// Base Repository.
    /// </summary>
    public class BaseRepository<Entity>
        : IDisposable, BaseRepositoryContract<Entity> where Entity : class, new()
    {
        /// <summary>
        /// Context to db;
        /// </summary>
        private readonly DbContext _context;

        /// <summary>
        /// DbSet repository.
        /// </summary>
        private DbSet<Entity> _dbset;

        /// <summary>
        /// Flag to dispose context.
        /// </summary>
        private bool disposed = false;

        /// <summary>
        /// Default constructor.
        /// </summary>
        /// <param name="context"> Context object.</param>
        public BaseRepository(DbContext context)
        {
            this._context = context;
            this._dbset = context.Set<Entity>();
        }

        /// <summary>
        /// Create entity from list in repository.
        /// </summary>
        /// <param name="entity">List of entities to create.</param>
        public void Create(Entity entity)
        {
            this._dbset.Add(entity);
        }

        /// <summary>
        /// Dispose this object.
        /// </summary>
        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Get entity by id(s).
        /// </summary>
        /// <param name="ids">Entity id(s) to get.</param>
        /// <returns>Object Entity.</returns>
        public Entity Get(object[] ids)
        {
            return this._dbset.Find(ids);
        }

        /// <summary>
        /// Get entities by expression filter.
        /// </summary>
        /// <param name="expressionFilter">Expression filter to  entities result
        /// (If null return without expression filter).</param>
        /// <returns>Entity List.</returns>
        public IEnumerable<Entity> Get(
            Expression<Func<Entity, bool>> expressionFilter = null)
        {
            IQueryable<Entity> query = this._dbset;

            if (expressionFilter != null)
                query = query.Where(expressionFilter);

            return query.AsNoTracking();
        }

        /// <summary>
        /// Save the context changes.
        /// </summary>
        public bool SaveChanges()
        {
            this._context.SaveChanges();
            return true;
        }

        /// <summary>
        /// Context Dispose.
        /// </summary>
        /// <param name="disposing">Flag to decide dispose context.</param>
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
                if (disposing)
                    this._context.Dispose();

            this.disposed = true;
        }
    }
}