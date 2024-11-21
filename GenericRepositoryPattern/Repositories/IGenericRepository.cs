using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.GenericRepositoryPattern.Repositories
{    
    public interface IGenericRepository<TEntity>
        where TEntity : class
    {
        /// <summary>
        /// To get all entitiesentity.
        /// </summary
        IEnumerable<TEntity> GetAll();
        /// <summary>
        /// To get an entity by id.
        /// </summary
        TEntity GetById(object id);
        /// <summary>
        /// To insert a new entity.
        /// </summary>
        void Insert(TEntity obj);
        /// <summary>
        /// To insert many new entities.
        /// </summary>
        void InsertMany(IEnumerable<TEntity> obj);
        /// <summary>
        /// To update an entity.
        /// </summary>
        void Update(TEntity obj);
        /// <summary>
        /// To delete an entity.
        /// </summary>
        void Delete(object id);
        /// <summary>
        /// To persist to the database.
        /// </summary>
        void Save();
        /// <summary>
        /// To persist to the database.
        /// </summary>
        Task<int> SaveAsync();


        /// <summary>
        /// Execute a sql command asynchronously.
        /// </summary>
        /// <param name="sql">The sql string.</param>
        /// <returns>Returns int.</returns>
        Task<IEnumerable<TEntity>> ExecuteSqlCommandAsync(FormattableString sql, CancellationToken cancellationToken = default);

        /// <summary>
        /// Execute a sql command asynchronously.
        /// </summary>
        /// <param name="sql">The sql string.</param>
        /// <param name="parameters">The parameters in the sql string.</param>
        /// <returns>Returns int.</returns>
        Task<IEnumerable<TEntity>> ExecuteSqlCommandWithParamAsync(string sql, params object[] parameters);

        /// <summary>
        /// Execute a sql command synchronously.
        /// </summary>
        /// <param name="sql">The sql string.</param>
        /// <returns>Returns int.</returns>
        IEnumerable<TEntity> ExecuteSqlCommand(FormattableString sql, CancellationToken cancellationToken = default);

        /// <summary>
        /// Execute a sql command synchronously.
        /// </summary>
        /// <param name="sql">The sql string.</param>
        /// <param name="parameters">The parameters in the sql string.</param>
        /// <returns>Returns int.</returns>
        IEnumerable<TEntity> ExecuteSqlCommandWithParam(string sql, params object[] parameters);


    }
}
