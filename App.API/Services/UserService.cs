using App.API.Models;
using EFGenericRepositoryPattern.Repositories;

namespace App.API.Services
{
    public class UserService
    {
        private readonly IGenericRepository<Utenti> _repository;

        public UserService(IGenericRepository<Utenti> repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Utenti>> GetAllEntitiesAsync()
        {
            return _repository.GetAll();
        }

        // Other service methods using the repository...
    }
}
