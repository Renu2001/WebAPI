using ModelLayer;
using RepositoryLayer.Context;
using RepositoryLayer.Entity;
using RepositoryLayer.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Service
{
    public class UserRL : IUserRL
    {
        private readonly ProjectContext _projectContext;
        public UserRL(ProjectContext projectContext)
        {
            this._projectContext = projectContext;
        }

        public UserEntity Adduser(UserModel user)
        {
            UserEntity userEntity = new UserEntity();
            userEntity.Name = user.Name;
            _projectContext.Users.Add(userEntity);
            _projectContext.SaveChanges();
            return userEntity;
        }

        public UserEntity Updateuser(int id, UserModel user)
        {
            var userEntity = _projectContext.Users.Find(id);
            userEntity.Name = user.Name;
            _projectContext.Users.Update(userEntity);
            _projectContext.SaveChanges();
            return userEntity;
        }
        public UserEntity DeleteUser(int id)
        {
            UserEntity userEntity = _projectContext.Users.Find(id);
            _projectContext.Users.Remove(userEntity);
            _projectContext.SaveChanges();
            return userEntity;
        }

        public List<UserEntity> Getusers()
        {
            var result = _projectContext.Users.ToList();
            return result;
        }
        public UserEntity Getuser(string name)
        {
            UserEntity userEntity = _projectContext.Users.FirstOrDefault(x => x.Name == name);
            return userEntity;
        }

    }
}
