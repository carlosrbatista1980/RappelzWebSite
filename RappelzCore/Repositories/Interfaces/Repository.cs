using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Common;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Design.Internal;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore.Internal;

namespace RappelzCore.Repositories.Interfaces
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class, IEntity<int>
    {
        protected DbSet<TEntity> dbSet;
        protected readonly DbContext db;

        public Repository(DbContext context)
        {
            dbSet = context.Set<TEntity>();
            db = context;
        }

        //IQueryable<TEntity> Select();
        /// <summary>
        /// Gets all records from a entity
        /// </summary> 
        /// <returns>IQuerable</returns>
        public IQueryable<TEntity> GetAll()
        {
            return dbSet.AsQueryable();
        }

        /// <summary>
        ///     Gets all records from a entity filtering by a condition.
        /// </summary>
        /// <example>
        ///     Ex: var records = GetAllWhere(x => x.Id == 1)  returns all records where Id is equal to 1
        /// </example> 
        /// <param name="predicate"></param>
        /// <returns></returns>
        public IQueryable<TEntity> GetAllWhere(Expression<Func<TEntity, bool>> predicate)
        {
            return dbSet.Where(predicate);
        }

        /// <summary>
        /// Adds an entity to a "list" to be saved for SaveChanges() or Save().
        /// </summary>
        /// <param name="entity"></param>
        public void Insert(TEntity entity)
        {
            dbSet.Add(entity);
            db.Entry(entity).State = EntityState.Added;
        }

        /// <summary>
        /// Remove a record from a entity
        /// </summary>
        /// <param name="entity"></param>
        public void Delete(TEntity entity)
        {
            dbSet.Remove(entity);
            db.Entry(entity).State = EntityState.Deleted;
        }

        /// <summary>
        /// Gets an entity by Id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public TEntity GetById(int id)
        {
            return dbSet.Find(id);
        }

        /// <summary>
        /// commit all changes added on database
        /// </summary>
        /// <param name="success"></param>
        /// <returns></returns>
        public bool Update(TEntity entity, bool CommitAllChangesOnSuccess = true)
        {
            try
            {
                db.SaveChanges(true);
                db.Entry(entity).State = EntityState.Modified;
                return true;
            }
            catch (DbUpdateException ex)
            {
                return false;
            }
        }
    }
}
