using App.API.Models;
using EFGenericRepositoryPattern.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace App.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UtentiController : ControllerBase
    {
        private readonly ILogger<UtentiController> _logger;
        private readonly IGenericRepository<Utenti> _repo;
        public UtentiController(ILogger<UtentiController> logger, IGenericRepository<Utenti> repo)
        {
            _logger = logger;
            _repo = repo;
        }
        // GET: api/<UtentiController>
        [HttpGet]
        public IEnumerable<Utenti> Get()
        {
            return _repo.GetAll();
        }
        [HttpGet("GetAllSql")]
        public IEnumerable<Utenti> GetAllSql()
        {
            return _repo.ExecuteSqlCommand($"select * from Utenti");
        }


        // GET api/<UtentiController>/5
        [HttpGet("{id}")]
        public Utenti Get(int id)
        {
            return _repo.GetById(id);
        }

        // POST api/<UtentiController>
        [HttpPost]
        public void Post([FromBody] Utenti value)
        {
        }

        // PUT api/<UtentiController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Utenti value)
        {
        }

        // DELETE api/<UtentiController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _repo.Delete(id);
        }
    }
}
