using LibraryManagementSystem.DTOs.User;
using LibraryManagementSystem.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController(IUserService userService) : ControllerBase
    {
        private readonly IUserService userService = userService;

        [HttpPost("create")]
        public async Task<IActionResult> CreateUser(CreateUserDTO userDetails)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                var req = await userService.CreateUser(userDetails);
                if (req.IsSuccess)
                {
                    return Ok(req);
                }
                else
                {
                    return BadRequest(req);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpGet("user/{id}")]
        public async Task<IActionResult> GetUserByID(Guid id)
        {
            try
            {
                var req = await userService.GetUserByID(id);
                if (req.IsSuccess)
                {
                    return Ok(req);
                }
                else if (req.StatusCode == 404)
                {
                    return NotFound(req);
                }
                else
                {
                    return BadRequest(req);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpGet("users")]
        public async Task<IActionResult> GetAllUsers()
        {
            try
            {
                var req = await userService.GetAllUsers();
                if (req.IsSuccess)
                {
                    return Ok(req);
                }
                else
                {
                    return BadRequest(req);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPut("update/{id}")]
        public async Task<IActionResult> UpdateUser(CreateUserDTO userDetails, Guid id)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                var req = await userService.UpdateUser(userDetails, id);
                if (req.IsSuccess)
                {
                    return Ok(req);
                }
                else if (req.StatusCode == 404)
                {
                    return NotFound(req);
                }
                else
                {
                    return BadRequest(req);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> DeleteUser(Guid id)
        {
            try
            {
                var req = await userService.Delete(id);
                if (req)
                {
                    return Ok(new { message = "User deleted successfully" });
                }
                else
                {
                    return NotFound(new { message = "User not found" });
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
