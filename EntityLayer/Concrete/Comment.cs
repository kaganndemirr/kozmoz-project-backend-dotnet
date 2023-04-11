using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }

        public int PostId { get; set; }

        public virtual Post Post { get; set; }

        public string Description { get; set; } = string.Empty;

        public DateTime CommentCreationDate { get; set; }

        public virtual User User { get; set; }
    }
}
