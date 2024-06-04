﻿using ModelLayer;
using RepositoryLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interface
{
    public interface IUserBL
    {
        public UserEntity Adduser(UserModel user);
        public UserEntity Updateuser(int id, UserModel user);
        public UserEntity DeleteUser(int id);
        public List<UserEntity> Getusers();


    }
}
