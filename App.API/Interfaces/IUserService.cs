using App.API.Models;
using System.Threading.Tasks;

namespace App.API.Interfaces
{
    public interface IUserService
    {
        Task<IEnumerable<Utenti>> GetAllEntitiesAsync();
        IEnumerable<Utenti> GetAllSql();
        IEnumerable<Utenti> GetAll();
        Utenti GetById(int id);
        void Delete(object id);
        void Save();
        Task<int> SaveAsync();
        Utenti Get(int id);
        IEnumerable<Utenti> ExecuteSqlCommand(FormattableString sql);
        void InsertMany(IEnumerable<Utenti> value);
    }
}
