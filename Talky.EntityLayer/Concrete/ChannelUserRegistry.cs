using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Talky.EntityLayer.Concrete
{
    public class ChannelUserRegistry
    {
        [Key]
        public int Id { get; set; }
        public DateTime Date { get; set; }

        public int ChannelId { get; set; }
        public virtual Channel Channel { get; set; }

        public int? UserId { get; set; }
        public virtual User User { get; set; }
    }
}
