﻿using DevFreela.API.Models;
using DevFreela.Application.InputModels;
using DevFreela.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DevFreela.API.Controllers
{
    [Route("api/users")]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var user = _userService.GetUser(id);

            if(user == null) 
                return NotFound();

            return Ok();
        }

        [HttpPost]
        public IActionResult Post([FromBody] CreateUserInputModel inputModel)
        {
            var id = _userService.Create(inputModel);
            return CreatedAtAction(nameof(GetById), new { Id = id }, inputModel);
        }

        [HttpPut("{id}/login")]
        public IActionResult Login(int id, LoginModel login)
        {
            return NoContent();
        }
    }
}
