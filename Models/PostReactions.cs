using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rare_BE.Models
{
    public class PostReactions
    {
        public int Id { get; set; }
        public int reaction_id { get; set; }
        public int user_id { get; set; }
        public int post_id { get; set; }
    }
}
