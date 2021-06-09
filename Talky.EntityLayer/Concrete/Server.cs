using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Talky.EntityLayer.Concrete
{
    public class Server
    {
        [Key]
        public int Id { get; set; }
        [StringLength(200)]
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public DateTime CreationDate { get; set; }

        public int? UserId { get; set; }
        public virtual User User { get; set; }

        public ICollection<Channel> Channels { get; set; }
        public ICollection<ServerUserRegistry> ServerUserRegistries { get; set; }
    }
}
