using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Talky.EntityLayer.Concrete
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [StringLength(200)]
        public string Name { get; set; }
        [StringLength(100)]
        public string Email { get; set; }
        [StringLength(20)]
        public string Password { get; set; }
        public string ImageUrl { get; set; }
        [StringLength(10)]
        public string Status { get; set; }

        public ICollection<Server> Servers { get; set; }
        public ICollection<ServerUserRegistry> ServerUserRegistries { get; set; }
        public ICollection<Channel> Channels { get; set; }
        public ICollection<Message> Messages { get; set; }
    }
}
