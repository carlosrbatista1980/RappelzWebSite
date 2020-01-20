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
using RappelzCore.Data;

namespace RappelzCore.Repositories.Interfaces
{
    //public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected DbSet<TEntity> dbSet;
        protected readonly AuthContext db;

        public Repository(AuthContext context)
        {
            dbSet = context.Set<TEntity>();
            db = context;
        }

        //IQueryable<TEntity> Select2(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
        //    List<Expression<Func<TEntity, object>>> includes = null,
        //    int? page = null,
        //    int? pageSize = null);

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
        ///     Gets all records from a entity filtering by a condition. (you can also use GetAll().Where(x => x.Id != 0) but, you will trigger 2 actions, GetAll() and Where filter)
        /// Using GetAllWhere you will trigger just one action, its much more faster.
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
        /// Adds an entity to be saved but, its not exists on database yet.
        /// </summary>
        /// <param name="entity"></param>
        public void Insert(TEntity entity)
        {
            dbSet.Add(entity);
            db.Entry(entity).State = EntityState.Added;
        }

        /// <summary>
        /// Remove an entity from database and commits its changes.
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
        public TEntity GetEntityById(int id)
        {
            return dbSet.Find(id);
        }

        /// <summary>
        /// Commits all changes added on database
        /// </summary>
        /// <param name="CommitAllChangesOnSuccess"></param>
        /// <returns></returns>
        public bool Update(TEntity entity, bool CommitAllChangesOnSuccess = true)
        {
            try
            {
                db.SaveChanges(CommitAllChangesOnSuccess);
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
