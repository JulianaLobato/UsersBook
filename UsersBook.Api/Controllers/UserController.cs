using Microsoft.AspNetCore.Mvc;
using UsersBook.Application.Interfaces;
using UsersBook.Domain.Models;

namespace UsersBook.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public readonly IUserAppService _appService;
        public UserController(IUserAppService appService)
        {
            _appService = appService;
        }

        [HttpGet]
        [ProducesResponseType(typeof(IList<UserModel>), 200)]
        public async Task<IActionResult> Get()
        {
            var response = await _appService.Get();

            return Ok(response);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(UserModel), 200)]
        public async Task<IActionResult> Get(int id)
        {
            var response = await _appService.Get(id);

            if (response is null)
                return NotFound();

            return Ok(response);
        }

        [HttpPost]
        [ProducesResponseType(201)]
        public async Task<IActionResult> Post([FromBody] UserModel user)
        {
            var response = await _appService.Create(user);
            return new ObjectResult(response) { StatusCode = StatusCodes.Status201Created };
        }

        [HttpPut("{id}")]
        [ProducesResponseType(204)]
        public async Task<IActionResult> Put(int id, [FromBody] UserModel user)
        {
            await _appService.Update(id, user);
            return NoContent();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(204)]
        public async Task<IActionResult> Delete(int id)
        {
            await _appService.Delete(id);
            return NoContent();
        }
    }
}
