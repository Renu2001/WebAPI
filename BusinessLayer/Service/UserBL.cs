using BusinessLayer.Interface;
using ModelLayer;
using RepositoryLayer.Entity;
using RepositoryLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Service
{
    public class UserBL : IUserBL
    {
        private readonly IUserRL _userRL;

        public UserBL(IUserRL userRL)
        {
            this._userRL = userRL;
        }

        public UserEntity Adduser(UserModel model)
        {
            return _userRL.Adduser(model);
        }

        public UserEntity Updateuser(int id, UserModel model)
        {
            return _userRL.Updateuser(id, model);
        }
        public UserEntity DeleteUser(int id)
        {
            return _userRL.DeleteUser(id);
        }
        public List<UserEntity> Getusers()
        {
            return _userRL.Getusers();
        }

        public UserEntity Getuser(string name)
        {
            return _userRL.Getuser(name);
        }

    }
}
