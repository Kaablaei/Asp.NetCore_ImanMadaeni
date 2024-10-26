using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toplern.Datalayer.Entities.User;

namespace Toplern.Datalayer.Context
{
    public class ToplernContext : DbContext 
    {
        public ToplernContext(DbContextOptions<ToplernContext > options):base(options)
        {
             
        }


        #region User

        public DbSet <Role> Rols { get; set; }

        public DbSet <User> Users { get; set; }
        public DbSet <UserRole> UsersRoles { get; set; }


        #endregion

    }
}
