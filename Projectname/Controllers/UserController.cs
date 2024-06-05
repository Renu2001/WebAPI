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
        public ResponseModel response;

        public UserController(IUserBL userBL)
        {
            this.userBL = userBL;
            this.response = new ResponseModel();
        }

        [HttpPost]
        public ResponseModel Adduser(UserModel model)
        {
            var result = userBL.Adduser(model);

            if (result != null)
            {
                this.response.Success = "true";
                this.response.Message = "User Added Successfully";
                this.response.Data = result;
                return response;
            }
            else
            {
                this.response.Success = "false";
                this.response.Message = "User Not Added";
                this.response.Data = null;
                return response;
            }
        }


        [HttpPut]
        public ResponseModel Updateuser(int id, UserModel model)
        {
            var result = userBL.Updateuser(id, model);
            if (result != null)
            {
                this.response.Success = "true";
                this.response.Message = "User Updated Successfully";
                this.response.Data = result;
                return response;
            }
            else
            {
                this.response.Success = "false";
                this.response.Message = "User Not Updated";
                this.response.Data = null;
                return response;
            }
        }
        [HttpDelete]
        public ResponseModel Deleteuser(int id)
        {
            var result = userBL.DeleteUser(id);
            if (result != null)
            {
                this.response.Success = "true";
                this.response.Message = "User Deleted Successfully";
                this.response.Data = result;
                return response;
            }
            else
            {
                this.response.Success = "false";
                this.response.Message = "User Not Deleted";
                this.response.Data = null;
                return response;
            }
        }
        [HttpGet]

        public ResponseModel GetUsers()
        {
            var result = userBL.Getusers();
            if (result != null)
            {
                this.response.Success = "true";
                this.response.Message = "Users Found";
                this.response.Data = result;
                return response;
            }
            else
            {
                this.response.Success = "false";
                this.response.Message = "No User Found";
                this.response.Data = null;
                return response;
            }
        }

        [HttpGet]
        [Route("{name}")]
        public ResponseModel GetUser(string name)
        {
            var result = userBL.Getuser(name);
            if (result != null)
            {
                this.response.Success = "true";
                this.response.Message = "User Found";
                this.response.Data = result;
                return response;
            }
            else
            {
                this.response.Success = "false";
                this.response.Message = "No User Found";
                this.response.Data = null;
                return response;
            }
        }

    }
}
