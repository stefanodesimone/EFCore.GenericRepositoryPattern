using Microsoft.EntityFrameworkCore;

namespace EFCore.GenericRepositoryPattern.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity>
        where TEntity : class
    {


        //private readonly Db871579957Context _context;
        private readonly DbContext _context;


        private readonly DbSet<TEntity> _dbSet;

        //public GenericRepository(Db871579957Context context)
        public GenericRepository(DbContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _dbSet.ToList();
        }

        public TEntity GetById(object id)
        {
            return _dbSet.Find(id);
        }

        public void Insert(TEntity obj)
        {
            _dbSet.Add(obj);
        }

        public void Update(TEntity obj)
        {
            _context.Entry(obj).State = EntityState.Modified;
        }

        public void Delete(object id)
        {
            TEntity existing = _dbSet.Find(id);
            _dbSet.Remove(existing);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public IEnumerable<TEntity> ExecuteSqlCommand(FormattableString sql, CancellationToken cancellationToken = default)
        {
            return _dbSet.FromSql(sql);
        }

        
        public IEnumerable<TEntity> ExecuteSqlCommandWithParam(string sql, params object[] parameters)
        {
            return  _dbSet.FromSqlRaw(sql, parameters);
            
        }

        public async Task<IEnumerable<TEntity>> ExecuteSqlCommandAsync(FormattableString sql, CancellationToken cancellationToken = default)
        {
            return await _dbSet.FromSql(sql).ToListAsync();
        }


        public async Task<IEnumerable<TEntity>> ExecuteSqlCommandWithParamAsync(string sql, params object[] parameters)
        {
            return await _dbSet.FromSqlRaw(sql, parameters).ToListAsync();

        }

    }
}
