using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Example.API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Example.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Controller<T> : ControllerBase where T : class
    {
        private readonly IService<T> _service;

        public Controller(IService<T> service)
        {
            _service = service;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<T>> Get()
        {
            return Ok(_service.GetAll());
        }

        // GET api/values/5
        [AllowAnonymous]
        [HttpGet("{id}")]
        public async Task<T> Get(Guid id)
        {
            return await _service.GetAsync(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] T value)
        {
            _service.AddAsync(value);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody] T value)
        {
            _service.UpdateAsync(id, value);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            _service.DeleteAsync(id);
        }
    }
}
