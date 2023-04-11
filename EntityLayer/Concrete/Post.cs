using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Post
    {
        [Key]
        public int PostId { get; set; }

        public int PostDescription { get; set; }

        public DateTime PostDate { get; set; }

        public string Media { get; set; } = string.Empty;

        public virtual User User { get; set; }
    }
}
