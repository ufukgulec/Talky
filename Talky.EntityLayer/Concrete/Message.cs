using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Talky.EntityLayer.Concrete
{
    public class Message
    {
        [Key]
        public int Id { get; set; }
        [StringLength(1000)]
        public string Content { get; set; }
        public DateTime SendingTime { get; set; }

        public int? UserId { get; set; }
        public virtual User User { get; set; }

        public int ChannelId { get; set; }
        public virtual Channel Channel { get; set; }
    }
}
