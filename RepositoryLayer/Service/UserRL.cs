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
       
         
    }
}
