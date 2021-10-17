using Blogapp.Domain.Entities.Entiti.DTOs;
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
        public IActionResult Post([FromBody] UserDTO dTO)
        {
            var id = userService.Add(dTO).ToString();
            var url = Url.Action("Get", new { id });
            return Created(url, id);
        }

        // PUT api/<User>/5
        [HttpPut("{id}")]
        public void Put([FromBody] UserDTO dTO)
        {

        }

        // DELETE api/<User>/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
        }
    }
}
