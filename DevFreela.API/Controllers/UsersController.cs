using DevFreela.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevFreela.API.Controllers
{
    [Route("api/users")]
    public class UsersController : ControllerBase
    {

        public UsersController(ExampleClass exampleClass)
        {
            //exampleClass.Name = "Updated At UsersController";
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult Post([FromBody] CreateUserModel createUserModel)
        {
            return CreatedAtAction(nameof(GetById), new { Id = 1 }, createUserModel);
        }

        [HttpPut("{id}/login")]
        public IActionResult Login(int id, LoginModel login)
        {
            return NoContent();
        }
    }
}
