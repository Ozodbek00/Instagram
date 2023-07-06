using Instagram.Api.Domain.Entities;
using Instagram.Api.Service.DTOs;
using Instagram.Api.Service.ServiceInterfaces;
using Microsoft.AspNetCore.Mvc;

namespace Instagram.Api.Controllers
{
    [ApiController, Route("api/[controller]")]
    public sealed class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public ActionResult<User> AddUser(UserForCreationDto userForCreationDto)
        {
            return Ok(_userService.Create(userForCreationDto));
        }

        [HttpGet("{id}")]
        public ActionResult<User> GetUser(long id)
        {
            return Ok(_userService.GetById(id));
        }

        [HttpPut]
        public ActionResult<User> Update(long id, UserForUpdateDto userForUpdateDto)
        {
            return Ok(_userService.Update(id, userForUpdateDto));
        }

        [HttpDelete]
        public IActionResult Delete(long id)
        {
            return Ok(_userService.Delete(id));
        }

        [HttpGet]
        public ActionResult<User[]> GetAll() 
        {
            return Ok(_userService.GetUsers());
        }
    }
}
