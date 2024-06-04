using BusinessLayer.Interface;
using BusinessLayer.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelLayer;

namespace Projectname.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserBL userBL;

        public UserController(IUserBL userBL)
        {
            this.userBL = userBL;
        }

        [HttpPost]
        public IActionResult Adduser(UserModel model)
        {
            var result = userBL.Adduser(model);

            if (result != null)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest("Something Went Wrong!!!");
            }
        }
    }
}
