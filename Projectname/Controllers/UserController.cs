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


        [HttpPut]
        public IActionResult Updateuser(int id, UserModel model)
        {
            var result = userBL.Updateuser(id, model);
            if (result != null)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest("Not Updated Successfully ");
            }
        }
        [HttpDelete]
        public IActionResult Deleteuser(int id)
        {
            var result = userBL.DeleteUser(id);
            if (result != null)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest("Something went Wrong !!!");
            }
        }
        [HttpGet]

        public IActionResult GetUsers()
        {
            var result = userBL.Getusers();
            if (result != null)
            {
                return Ok(result);
            }
            else
            {
                return NotFound("User Not Found!!!");
            }
        }

        [HttpGet]
        [Route("{name}")]
        public IActionResult GetUser(string name)
        {
            var result = userBL.Getuser(name);
            if (result != null)
            {
                return Ok(result);
            }
            else
            {
                return NotFound("User Not Found!!!");
            }
        }

    }
}
