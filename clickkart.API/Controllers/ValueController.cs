using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace clickkart.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ValueController : ControllerBase
    {
        private readonly clickkart.API.DataAccess.data _db;
        public ValueController(clickkart.API.DataAccess.data db)
        {
                _db=db;
        }
          // GET api/values
        // [HttpGet]
        // public ActionResult<IEnumerable<string>> Get()
        // {
        //     return new string[] { "value1", "value2" };
        // }
        [HttpGet]
        public async Task<IActionResult>  GetDbValue()
        {
            var values=await _db.values.ToListAsync();
            return Ok(values);
        }

        // GET api/values/5
        // [HttpGet("{id}")]
        // public ActionResult<string> Get(int id)
        // {
        //     return "value";
        // }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetValueById(int id)
        {
            var values= await _db.values.FirstOrDefaultAsync(x=>x.Id==id);
            return Ok(values);
        }
        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
