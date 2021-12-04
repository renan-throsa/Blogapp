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
            UserDTO user = userService.Read(id);
            if (user != null) return Ok(user);
            return NotFound(id);
        }

        // POST api/<User>
        [HttpPost]
        public IActionResult Post([FromBody] UserDTO dto)
        {
            var id = userService.Add(dto).ToString();
            var url = Url.Action("Get", new { id });
            return Created(url, id);
        }

        // PUT api/<User>/5
        [HttpPut]
        public IActionResult Put([FromBody] UserDTO dto)
        {
            UserDTO user = userService.Read(dto.Id);
            if (user == null) return NotFound(dto.Id);
            return Ok(userService.Edit(dto));
        }

        // DELETE api/<User>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            userService.Delete(id);
            return Ok();
        }
    }
}
