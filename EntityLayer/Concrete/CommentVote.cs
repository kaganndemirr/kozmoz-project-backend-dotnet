using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class CommentVote
    {
        [Key]
        public int CommentVoteId { get; set; }

        public virtual Vote CommentVoteType { get; set; }

        public DateTime CommentVoteDate { get; set; }

        public virtual User User { get; set; }

        public short VoteId { get; set; }

        public VoteEnum VoteEnum => (VoteEnum)VoteId;
    }

}
