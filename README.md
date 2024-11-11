# GenericRepositoryPattern

Implement in a web api or MVC web app project:
In program.cs insert these lines:
```c#
string conn = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<NameofTheContext>(options =>
                                options.UseSqlServer(conn));
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped<DbContext, NameofTheContext>();
```
