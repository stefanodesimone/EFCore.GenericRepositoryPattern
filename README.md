# Entity Framework Core Generic Repository Pattern
This repo provides implementation generic repository pattern on Entity Framework Core
To implement in a web api or MVC web app project:
In program.cs insert these lines:
```c#
string conn = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<NameofTheContext>(options =>
                                options.UseSqlServer(conn));
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped<DbContext, NameofTheContext>();
```
# Usage example
```c#
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
}
```
