﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rare_BE.Models
{
    public class PostReactions
    {
        public int Id { get; set; }
        public int Reaction_Id { get; set; }
        public int UserId { get; set; }
        public int PostId { get; set; }
    }
}
