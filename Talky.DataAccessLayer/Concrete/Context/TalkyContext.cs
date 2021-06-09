using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Talky.EntityLayer.Concrete;

namespace Talky.DataAccessLayer.Concrete.Context
{
    public class TalkyContext : DbContext
    {
        public DbSet<Channel> Channels { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Server> Servers { get; set; }
        public DbSet<ServerUserRegistry> ServerUserRegistries { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
