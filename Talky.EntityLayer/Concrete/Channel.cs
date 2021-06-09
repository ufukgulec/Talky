using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Talky.EntityLayer.Concrete
{
    public class Channel
    {
        [Key]
        public int Id { get; set; }
        [StringLength(200)]
        public string Name { get; set; }
        [StringLength(500)]
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }

        public int ServerId { get; set; }
        public virtual Server Server { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }

        public ICollection<Message> Messages { get; set; }
    }
}
