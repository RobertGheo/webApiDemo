using Microsoft.AspNetCore.Mvc;

namespace ApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        // GET: api/Users
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2"};
        }

        // GET api/Users/5
        [HttpGet("{id}")]
        public string Get(int id, double id2)
        {
            double result = id + id2;
            return $"value {result}";
        }

        // POST api/Users
        [HttpPost("{type}")]
        public string Post([FromBody] string value)
        {
            return $"value";
        }

        // PUT api/Users/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/Users/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
