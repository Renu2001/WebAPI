﻿using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Context
{
    public class ProjectContext : DbContext
    {
        public ProjectContext(DbContextOptions options) : base(options) { }

        public DbSet<UserEntity> Users { get; set; }
    }
}
