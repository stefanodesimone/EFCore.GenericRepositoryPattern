using App.API.Interfaces;
using App.API.Models;
using EFGenericRepositoryPattern.Repositories;

namespace App.API.Services
{
    public class UserService : IUserService
    {
        private readonly IGenericRepository<Utenti> _repo;

        public UserService(IGenericRepository<Utenti> repository)
        {
            _repo = repository;
        }

        public void Delete(object id)
        {
            _repo.Delete(id);
        }

        public IEnumerable<Utenti> ExecuteSqlCommand(FormattableString sql)
        {
            return _repo.ExecuteSqlCommand(sql);
        }

        public Utenti Get(int id)
        {
            return _repo.GetById(id);
        }

        public IEnumerable<Utenti> GetAll()
        {
           return _repo.GetAll();
        }

        public async Task<IEnumerable<Utenti>> GetAllEntitiesAsync()
        {
            return _repo.GetAll();
        }

        public IEnumerable<Utenti> GetAllSql(FormattableString sql )
        {
            return _repo.ExecuteSqlCommand(sql);
        }

        public IEnumerable<Utenti> GetAllSql()
        {
            throw new NotImplementedException();
        }

        public Utenti GetById(int id)
        {
            return _repo.GetById(id);
        }

        public void Save()
        {
            _repo.Save();
        }

        public async Task<int> SaveAsync()
        {
            return await _repo.SaveAsync();
        }

        // Other service methods using the repository...
    }
}
