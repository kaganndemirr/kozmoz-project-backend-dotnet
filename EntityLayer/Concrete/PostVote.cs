using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class PostVote
    {
        [Key]
        public int PostVoteId { get; set; }

        public virtual Vote PostVoteType { get; set; }

        public DateTime PostVoteDate { get; set; }

        public virtual User User { get; set; }

        public short VoteId { get; set; }

        public VoteEnum VoteEnum => (VoteEnum)VoteId;
    }
}
