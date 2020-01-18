using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace RappelzCore.Repositories.Interfaces
{
    public interface IRepository<TEntity>
    {
        /// <summary>
        /// Gets all records from a entity
        /// </summary> 
        /// <returns>IQuerable</returns>
        IQueryable<TEntity> GetAll();

        /// <summary>
        ///     Gets all records from a entity filtering by a condition.
        /// </summary>
        /// <example>
        ///     Ex: var records = GetAllWhere(x => x.Id == 1)  returns all records where Id is equal to 1
        /// </example> 
        /// <param name="predicate"></param>
        /// <returns></returns>
        IQueryable<TEntity> GetAllWhere(Expression<Func<TEntity, bool>> predicate);

        /// <summary>
        /// Gets an entity by Id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        TEntity GetEntityById(int Id);
        
        /// <summary>
        /// Adds an entity to a "list" to be saved for SaveChanges() or Save().
        /// </summary>
        /// <param name="entity"></param>
        void Insert(TEntity entity);

        /// <summary>
        /// Remove a record from a entity
        /// </summary>
        /// <param name="entity"></param>
        void Delete(TEntity entity);

        /// <summary>
        /// commit all changes added on database
        /// </summary>
        /// <param name="success"></param>
        /// <returns></returns>
        bool Update(TEntity entity, bool success);
    }
}