using Microsoft.AspNetCore.Mvc;
using TestTask.Exceptions;
using TestTask.Services;
using TestTask.Services.Interfaces;

namespace TestTask.Controllers
{
    /// <summary>
    /// Users controller.
    /// DO NOT change anything here. Use created contract and provide only needed implementation.
    /// </summary>
    [Route("api/v1/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        /// <summary>
        /// Returns selected user. 
        /// Selection rules are specified in Task description provided by recruiter
        /// </summary>
        [HttpGet]
        [Route("selected-user")]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> GetUserWithMaxOrderCount()
        {
            try
            {
                var user = await _userService.GetUserWithMaxOrderCount();

                return Ok(user);
            }

            catch (Exception ex)
            {
                return ex switch
                {
                    OrderNotFoundException e => NotFound(),

                    _ => StatusCode(500),
                };
            }
        }

        /// <summary>
        /// Returns list of selected users. 
        /// Selection rules are specified in Task description provided by recruiter
        /// </summary>
        [HttpGet]
        [Route(" ")]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> GetInactiveUsers()
        {
            try
            {
                var users = await _userService.GetInactiveUsers();

                return Ok(users);
            }

            catch (Exception ex)
            {
                return ex switch
                {
                    OrderNotFoundException e => NotFound(),

                    _ => StatusCode(500),
                };
            }
        }
    }
}
