using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Vote
    {
        public short Id { get; set; }

        public string Name { get; set; } = string.Empty;
    }

    public enum VoteEnum
    {
        Like = 0,
        Sad = 1,
        Funny = 2,
        Angry = 3,
    }
}
