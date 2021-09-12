using Blogapp.Domain.Entities.Entities.DTOs;
using Blogapp.Domain.IServices;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


namespace Blogapp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        // GET: api/<User>
        [HttpGet]
        public IEnumerable<UserDTO> Get()
        {
            return userService.Browse();
        }

        // GET api/<User>/5
        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            var user = userService.Read(id);
            if (user != null) return Ok(user);
            return NotFound(id);
        }

        // POST api/<User>
        [HttpPost]
        public IActionResult Post([FromBody] UserDTO dto)
        {
            return Ok(userService.Add(dto));
        }

        // PUT api/<User>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<User>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
