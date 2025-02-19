using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using UserManagerUI.Api.Models;
using UserManagerUI.Api.Services.Interfaces;

namespace UserManagerUI.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("Create")]
        public async Task<User> Create()
        {
           var result = _userService.Create();
            return result;
        }

        [HttpGet("Get-All")]
        public async Task<User[]> GetAll()
        {
            var users = _userService.GetAll();
            return users.ToArray();
        }

        [HttpPost("Update")]
        public async Task<User> Update([FromBody] User user)
        {
            throw new NotImplementedException();
        }

        [HttpPost("Delete")]
        public async Task<User> Delete([FromBody] int id)
        {
            throw new NotImplementedException();
        }
    }
}
